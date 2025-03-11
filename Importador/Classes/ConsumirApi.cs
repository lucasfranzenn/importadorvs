using DevExpress.XtraEditors;
using Importador.Classes.Entidades.RetornoAPI;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Importador.Classes
{
    internal static class ConsumirApi
    {
        public static async Task<JiraIssue> GetIssueOnJira(string issue_id)
        {
            Uri uri = new(IniFile.Read("Integracao", "JiraEndPoint").Replace(@"\", @"").Replace("{issue_id}", issue_id));

            using (HttpClient client = new HttpClient())
            {
                string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(IniFile.Read("Integracao", "JiraAuth")));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(uri);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();
                        JiraIssue jiraa = JiraIssue.FromJson(responseData);

                        if (jiraa.Total > 0) return jiraa;
                    }
                    else
                    {
                        XtraMessageBox.Show($"Erro ao consultar API:\n{response.StatusCode} - {response.ReasonPhrase}", "..::Importador de Dados::..");
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"Erro ao consumir API: {ex.Message}", "..::Importador de Dados::..");
                }
            }

            return null;
        }
    }
}
