<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Insert title here</title>
</head>
<body>





<form action="insert.jsp" method="get">
		<table style="background-color: lightgrey; margin: auto">
			<tr>
			
				<td>Enter firstName</td>
				<td><input type="text" name="firstname" /></td>
			</tr>
			<tr>
			
				<td>Enter Last Name</td>
				<td><input type="text" name="lastname" /></td>
			</tr>
			<tr>
			
				<td>Enter Department</td>
				<td><input type="text" name="dept" /></td>
			</tr>
			
			<tr>
				<td>Enter Salary Limit</td>
				<td><input type="number" name="salary" /></td>
			</tr>

			<tr>
				<td><input type="submit" value="Insert Emps" /></td>
			</tr>
		</table>
	</form>

</body>
</html>