<!DOCTYPE html>
<html>
<head>
	<title>Sign Up Form</title>
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="css/bootstrap.css" rel="stylesheet">
    <link href="css/bootstrap-theme.min.css" rel="stylesheet" media="screen">
    <link href="css/my-styles.css" rel="stylesheet" media="screen">
    <link rel="stylesheet" href="css/signupstyle.css" type="text/css" media="screen" title="no title" charset="utf-8">
    <!-- HTML5 shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src="../../assets/js/html5shiv.js"></script>
      <script src="../../assets/js/respond.min.js"></script>
    <![endif]-->
</head>
<body>

	<form action="#" method="post">
		<p>
			<label for="username">Username</label>
			<input id="username" name="username" type="text">
		</p>
		<p>
			<label for="password">Password</label>
			<input id="password" name="password" type="password">
			<span>Enter a password longer than 8 characters</span>
		</p>
		<p>
			<label for="confirm_password">Confirm Password</label>
			<input id="confirm_password" name="confirm_password" type="password">
			<span>Please confirm your password</span>
		</p>
		<p>
			<input type="submit" value="SUBMIT" id="submit">
		</p>
	</form>
	<script src="http://code.jquery.com/jquery-1.11.0.min.js" type="text/javascript" charset="utf-8"></script>
	<script src="js/app.js" type="text/javascript" charset="utf-8"></script>
</body>
</html>