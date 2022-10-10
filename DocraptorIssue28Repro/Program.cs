using System.IO;
using System.Web;
using DocRaptor.Api;
using DocRaptor.Model;

namespace DocraptorIssue28Repro
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var html = @"<html>
<body>
    <p>Hello World</p>
</body>
</html>";

            var apiKey = "Not Relevant";

            var docRaptorConfig = new DocRaptor.Client.Configuration {Username = apiKey};
            var docApi = new DocApi(docRaptorConfig);

            html = HttpUtility.HtmlDecode(html);
            
            var isTest = true;

            var doc = new Doc(
                test: isTest,
                documentContent: html,
                name: "file.pdf",
                documentType: Doc.DocumentTypeEnum.Pdf,
                princeOptions: new PrinceOptions { Media = "screen" }
            );

            var pdfBytes = docApi.CreateDoc(doc);

            File.WriteAllBytes("./output.pdf", pdfBytes);
        }
    }
}
