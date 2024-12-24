using DevExpress.XtraEditors;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Importador.Classes.Entidades;
using Importador.Conexao;
using Importador.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Windows.ApplicationModel.Store.Preview.InstallControl;

namespace Importador.Classes
{
    public static class GoogleDrive
    {
        internal static void Upload(string credencialDrive, string caminho)
        {
            string parentFolderId = Utils.LerArquivo(Constantes.Caminhos.PastaPaiDrive);

            try
            {
                GoogleCredential credential;
                using (var stream = new FileStream(credencialDrive, FileMode.Open, FileAccess.Read))
                {
                    credential = GoogleCredential.FromStream(stream).CreateScoped(new[]
                    {
                    DriveService.ScopeConstants.DriveFile
                });
                }

                var service = new DriveService(new BaseClientService.Initializer
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Importacao"
                });

                var fileMetadata = new Google.Apis.Drive.v3.Data.File
                {
                    Name = Path.GetFileName(caminho),
                    Parents = new List<string> { EnsureFolderExists(service, $"{Configuracoes.Default.CodigoImplantacao} - {ConexaoBancoImportador.GetEntidade<Implantacao>(Constantes.Enums.TabelaBancoLocal.implantacoes).RazaoSocialCliente}", parentFolderId) }
                };

                using (var fileStream = new FileStream(caminho, FileMode.Open, FileAccess.Read))
                {
                    var request = service.Files.Create(fileMetadata, fileStream, "application/rar");
                    request.Fields = "id";
                    request.Upload();

                    var fileId = request.ResponseBody?.Id;
                    if (!string.IsNullOrEmpty(fileId))
                    {
                        Utils.MostrarNotificacao($"Upload concluído com sucesso. ID do arquivo: {fileId}\nCopiado para Área de Transfêrencia!", "..::Google Drive::..");
                        Clipboard.SetText($"SCRIPT: https://drive.google.com/file/d/{fileId}/view{Environment.NewLine}PASTA NO DRIVE: https://drive.google.com/drive/u/3/folders/{fileMetadata.Parents[0]}");
                    }
                    else
                    {
                        XtraMessageBox.Show("Falha ao obter o ID do arquivo após o upload.");
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Erro ao realizar o upload para o Google Drive: {ex.Message}");
            }
        }

        private static string EnsureFolderExists(DriveService service, string folderName, string parentFolderId)
        {
            try
            {
                var request = service.Files.List();
                request.Q = $"mimeType='application/vnd.google-apps.folder' and name='{folderName}' and '{parentFolderId}' in parents and trashed=false";
                request.Fields = "files(id, name)";
                var result = request.Execute();

                if (result.Files?.Count > 0)
                {
                    //$"Pasta encontrada: {folderName}, ID: {result.Files[0].Id}");
                    return result.Files[0].Id;
                }

                var folderMetadata = new Google.Apis.Drive.v3.Data.File
                {
                    Name = folderName,
                    MimeType = "application/vnd.google-apps.folder",
                    Parents = new[] { parentFolderId }
                };

                var createRequest = service.Files.Create(folderMetadata);
                createRequest.Fields = "id";
                var folder = createRequest.Execute();

                //$"Pasta criada: {folderName}, ID: {folder.Id}");
                return folder.Id;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao verificar ou criar a pasta: {ex.Message}");
                throw;
            }
        }
    }
    
}
