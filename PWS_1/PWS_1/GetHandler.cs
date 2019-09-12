using System;
using System.Web;
using System.Web.Script.Serialization;

namespace PWS_1
{
    public class GetHandler : IHttpHandler
    {
        /// <summary>
        /// Вам потребуется настроить этот обработчик в файле Web.config вашего 
        /// веб-сайта и зарегистрировать его с помощью IIS, чтобы затем воспользоваться им.
        /// см. на этой странице: https://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region Члены IHttpHandler

        public bool IsReusable
        {
            // Верните значение false в том случае, если ваш управляемый обработчик не может быть повторно использован для другого запроса.
            // Обычно значение false соответствует случаю, когда некоторые данные о состоянии сохранены по запросу.
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            HttpResponse res = context.Response;

            res.ContentType = "application/json";

            try
            {
                int top = Result.stack.Peek();
                res.Write(js.Serialize(new { result = Result.result + top, stack = Result.stack }));
            }
            catch (InvalidOperationException)
            {
                res.Write(js.Serialize(new { result = Result.result, stack = "Stack is empty" }));
            }
        }

        #endregion
    }
}
