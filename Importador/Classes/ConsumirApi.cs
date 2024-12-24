using DevExpress.XtraEditors;
using Importador.Classes.Entidades.RetornoAPI;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            Uri uri = new($"https://lucas-franzenn.atlassian.net/rest/api/3/search?jql=summary~\"{issue_id}*\" and issuetype=\"10026\"&fields=summary,customfield_10070,customfield_10071,customfield_10072,customfield_10073,customfield_10074,customfield_10075,customfield_10068, customfield_10081, customfield_10082");

            using (HttpClient client = new HttpClient())
            {
                string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(Utils.LerArquivo(Constantes.Caminhos.AuthJira)));
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
