<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CalculadoraPOO.INDEX" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Compiled and minified CSS -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css" />
    <link href="https://fonts.googleapis.com/css?family=Roboto+Mono&display=swap" rel="stylesheet" />
    <link href="css/app.css" rel="stylesheet" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>C# Calculator POO</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div id="contenedor">
            <div class="card grey darken-4 cajacentro z-depth-5 white-text">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <div class="row">
                            <div class="col s12 m8">
                                <div class="row right-align rowconpad rowsinmag">
                                    <asp:Label ID="lblproc" runat="server" Text="" CssClass="proceso"></asp:Label>
                                </div>
                                <div class="row right-align rowconpad">
                                    <asp:Label ID="lblres" runat="server" Text="0" CssClass="resultado"></asp:Label>
                                </div>
                                <div class="row rowconpad rowsinmag">
                                    <div class="col s3 colsinpad">
                                        <asp:Button ID="btn7" runat="server" Text="7" OnClick="btn7_Click" CssClass="btnproc black white-text" />
                                    </div>
                                    <div class="col s3 colsinpad">
                                        <asp:Button ID="btn8" runat="server" Text="8" OnClick="btn8_Click" CssClass="btnproc black white-text"/>
                                    </div>
                                    <div class="col s3 colsinpad">
                                        <asp:Button ID="btn9" runat="server" Text="9" OnClick="btn9_Click" CssClass="btnproc black white-text"/>
                                    </div>
                                    <div class="col s3 colsinpad">
                                        <asp:Button ID="btndiv" runat="server" Text="/" OnClick="btndiv_Click" CssClass="btnproc black white-text"/>
                                    </div>
                                </div>
                                <div class="row rowconpad rowsinmag">
                                    <div class="col s3 colsinpad">
                                        <asp:Button ID="btn4" runat="server" Text="4" OnClick="btn4_Click" CssClass="btnproc black white-text"/>
                                    </div>
                                    <div class="col s3 colsinpad">
                                        <asp:Button ID="btn5" runat="server" Text="5" OnClick="btn5_Click" CssClass="btnproc black white-text"/>
                                    </div>
                                    <div class="col s3 colsinpad">
                                        <asp:Button ID="btn6" runat="server" Text="6" OnClick="btn6_Click" CssClass="btnproc black white-text"/>
                                        
                                    </div>
                                    <div class="col s3 colsinpad">
                                        <asp:Button ID="btnmult" runat="server" Text="x" OnClick="btnmult_Click" CssClass="btnproc black white-text"/>
                                    </div>
                                </div>
                                <div class="row rowconpad rowsinmag">
                                    <div class="col s3 colsinpad">
                                        <asp:Button ID="btn1" runat="server" Text="1" OnClick="btn1_Click" CssClass="btnproc black white-text"/>
                                    </div>
                                    <div class="col s3 colsinpad">
                                        <asp:Button ID="btn2" runat="server" Text="2" OnClick="btn2_Click" CssClass="btnproc black white-text"/>
                                    </div>
                                    <div class="col s3 colsinpad">
                                        <asp:Button ID="btn3" runat="server" Text="3" OnClick="btn3_Click" CssClass="btnproc black white-text"/>
                                    </div>
                                    <div class="col s3 colsinpad">
                                        <asp:Button ID="btnres" runat="server" Text="-" OnClick="btnres_Click" CssClass="btnproc black white-text"/>
                                    </div>
                                </div>
                                <div class="row rowconpad rowsinmag">
                                    <div class="col s3 colsinpad">
                                        <asp:Button ID="btnc" runat="server" Text="C" OnClick="btnc_Click" CssClass="btnproc black white-text"/>
                                    </div>
                                    <div class="col s3 colsinpad">
                                        <asp:Button ID="btn0" runat="server" Text="0" OnClick="btn0_Click" CssClass="btnproc black white-text"/>
                                    </div>
                                    <div class="col s3 colsinpad">
                                        <asp:Button ID="btnce" runat="server" Text="CE" OnClick="btnce_Click" CssClass="btnproc black white-text"/>
                                    </div>
                                    <div class="col s3 colsinpad">
                                        <asp:Button ID="btnsum" runat="server" Text="+" OnClick="btnsum_Click" CssClass="btnproc black white-text"/>
                                    </div>
                                </div>
                                <div class="row rowconpad rowsinmag">
                                    <asp:Button ID="btneq" runat="server" Text="=" OnClick="btneq_Click" CssClass="btnproc black white-text"/>
                                </div>
                                
                            </div>
                            <div class="col s12 m4">
                                <div class="row rowsinmag">
                                    <h6>Historial</h6>
                                </div>
                                <div class="row right-align rowsinmag">
                                    <asp:Label ID="lblhist" runat="server" Text="" CssClass="historial"></asp:Label>
                                </div>
                                
                            </div>
                        </div>  
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
    </form>
</body>
</html>
