<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%
    var viewModel = ViewData.Model;
%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
    <title>Index</title>
</head>
<body>
    <div>
        <span>First Property value : <%= viewModel.Name %></span> <br />
        <span>Second Property value :  <%= viewModel.SomeInts.Length %></span><br />
        <span>A Sample Method Impl : <%= ((Func<string>) viewModel.AMethod)()%></span>
    </div>
</body>
</html> 
