using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using global_azure_day2023.Model.Shared.Models;

namespace global_azure_day2023.Function
{
    public static class GetSpeakersFunction
    {
        [FunctionName("GetSessions")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {

            string jsondata = @"[
                                  {
                                    ""sessionName"": ""Boost Your Development Productivity with Azure PaaS Services"",
                                    ""speakerName"": ""Rijwan Ansari"",
                                    ""eventDate"": ""2023-05-13"",
                                    ""eventTime"": ""10:15 AM"",
                                    ""slotName"": ""Track 1""
                                  },
                                  {
                                    ""sessionName"": ""Boost Your Development Productivity with Azure PaaS Services"",
                                    ""speakerName"": ""Akash Jain"",
                                    ""eventDate"": ""2023-05-13"",
                                    ""eventTime"": ""10:15 AM"",
                                    ""slotName"": ""Track 2""
                                  },
                                  {
                                    ""sessionName"": ""Understand the importance of Azure Key Vault"",
                                    ""speakerName"": ""Aakash Maurya"",
                                    ""eventDate"": ""2023-05-13"",
                                    ""eventTime"": ""11:00 AM"",
                                    ""slotName"": ""Track 1""
                                  },
                                  {
                                    ""sessionName"": ""Provision azure resources using Azure infrastructure as a code"",
                                    ""speakerName"": ""Shrushti Shah"",
                                    ""eventDate"": ""2023-05-13"",
                                    ""eventTime"": ""11:00 AM"",
                                    ""slotName"": ""Track 2""
                                  },
                                  {
                                    ""sessionName"": ""Microservices CI/CD pipelines with Azure DevOps and Azure Kubernetes Service"",
                                    ""speakerName"": ""Abdul Karim Memon"",
                                    ""eventDate"": ""2023-05-13"",
                                    ""eventTime"": ""11:45 AM"",
                                    ""slotName"": ""Track 1""
                                  },
                                  {
                                    ""sessionName"": ""Build your first Azure Data Factory Pipeline"",
                                    ""speakerName"": ""Harun Raseed Basheer"",
                                    ""eventDate"": ""2023-05-13"",
                                    ""eventTime"": ""11:45 AM"",
                                    ""slotName"": ""Track 2""
                                  },
                                  {
                                    ""sessionName"": ""Unveiling the potential of Applied AI Apps with Azure Cosmos DB"",
                                    ""speakerName"": ""Janarthanan Selvaraj"",
                                    ""eventDate"": ""2023-05-13"",
                                    ""eventTime"": ""12:30 PM"",
                                    ""slotName"": ""Track 1""
                                  },
                                  {
                                    ""sessionName"": ""Develop and Publish a Blazor WebAssembly App and. NET API with Azure Static Web Apps"",
                                    ""speakerName"": ""Debasis Saha"",
                                    ""eventDate"": ""2023-05-13"",
                                    ""eventTime"": ""12:30 PM"",
                                    ""slotName"": ""Track 2""
                                  },
                                  {
                                    ""sessionName"": ""Implementing Low Code CQRS with Azure Logic Apps"",
                                    ""speakerName"": ""Mandar Dharmadhikari"",
                                    ""eventDate"": ""2023-05-13"",
                                    ""eventTime"": ""01:15 PM"",
                                    ""slotName"": ""Track 1""
                                  },
                                  {
                                    ""sessionName"": ""IaC made easy with Azure Bicep"",
                                    ""speakerName"": ""Arun Ramaswamy"",
                                    ""eventDate"": ""2023-05-13"",
                                    ""eventTime"": ""01:15 PM"",
                                    ""slotName"": ""Track 2""
                                  }
                                ]";

            var result = JsonConvert.DeserializeObject<List<Speaker>>(jsondata);

            return new OkObjectResult(result);
        }
    }
}
