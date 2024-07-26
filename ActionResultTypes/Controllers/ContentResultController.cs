using Microsoft.AspNetCore.Mvc;

namespace ActionResultTypes.Controllers
{
    public class ContentResultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ContentResult GetContentResult()
        {
            string content = "Hello Content";
            return Content(content, "text/plain", System.Text.Encoding.UTF8);
        }

        public ContentResult GetHtmlContent()
        {
            string content = "<!DOCTYPE html>" +
                "<html>" +
                    "<head lang='en'>" +
                        "<meta charset='utf-8'>" +
                    "</head>" +
                    "<body>" +
                        "<h1>Hello World</h1>" +
                    "</body>" +
                "</html>";
            ContentResult contentResult = new ContentResult();
            contentResult.Content = content;
            contentResult.ContentType = "text/html";
            return contentResult;
        }

        public EmptyResult GetEmptyResult()
        {
            return new EmptyResult();
        }
    }
}
