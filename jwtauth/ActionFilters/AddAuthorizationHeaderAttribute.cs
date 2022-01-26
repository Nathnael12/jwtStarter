
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;

namespace jwtauth.ActionFilters
{
    public class AddAuthorizationHeaderAttribute : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJqd3QgYXV0aCB0ZXN0ZXIiLCJlbWFpbCI6InRlc3Quand0QGF1dGguY29tIiwianRpIjoiZDgwODAzNTQtZDM5ZS00ZGRkLTlhZTEtNDgyYWEzYzkzNTlhIiwiZXhwIjoxNjQzMTg4MDYzfQ.cZP-yvJPTA5-ugB6VIlN4mNjj-NoLCWqQ2JeOXsMKMw";
            context.HttpContext.Request.Headers.Add("Authorization", "Bearer "+token);
        }
    }
}
