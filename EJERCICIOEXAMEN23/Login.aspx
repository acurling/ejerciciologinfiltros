<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EJERCICIOEXAMEN23.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
       <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
 

   <link href="https://fonts.googleapis.com/css?family=Lato:300,400,700&display=swap" rel="stylesheet">

   <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">

   <link rel="stylesheet" href="css/style.css">
</head>
<body class="img js-fullheight" style="background-image: url(images/AfroSamurai2.jfif);">
    <section class="ftco-section">
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-md-6 text-center mb-5">
                    <h2 class="heading-section">Login #10</h2>
                </div>
            </div>
            <div class="row justify-content-center">
                <div class="col-md-6 col-lg-4">
                    <div class="login-wrap p-0">
                        <h3 class="mb-4 text-center">Have an account?</h3>
                        <form id="form1" runat="server" action="#" class="signin-form">
                            <div class="form-group">
                                <asp:TextBox ID="tcorreo" placeholder="Digite el correo" class="form-control" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="tclave" class="form-control" placeholder="Clave" TextMode="Password" runat="server"></asp:TextBox>
                                <span toggle="#password-field" class="fa fa-fw fa-eye field-icon toggle-password"></span>
                            </div>
                            <div class="form-group">
                                <asp:Button ID="bagregar" class="form-control btn btn-primary submit px-3" runat="server" Text="ingresar" OnClick="bagregar_Click" />
                                </div>
                            
                        </form>
                        
                    </div>
                </div>
            </div>
        </div>
    </section>

    <script src="js/jquery.min.js"></script>
    <script src="js/popper.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/main.js"></script>

</body>
</html>
