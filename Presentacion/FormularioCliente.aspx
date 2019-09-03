<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormularioCliente.aspx.cs" Inherits="Presentacion.FormularioCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="card w-75">
            <div class="card-body">
                <div class="row">
                    <div class="col-md-6">
                        <h3>Formulario de clientes
                        </h3>

                        <div class="form-group">
                            <asp:Label ID="lblNombreApellido" runat="server" Text="Nombre y Apellido"></asp:Label>
                            <asp:TextBox ID="txtNombreApellido" type="text" runat="server" Class="form-control"></asp:TextBox>
                        </div>
                        
                        <div class="form-group">
                            <asp:Label ID="lblEdad" runat="server" Text="Edad"></asp:Label>
                            <asp:TextBox ID="txtEdad" type="text" runat="server" Class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblDocumento" runat="server" Text="Documento"></asp:Label>
                            <asp:TextBox ID="txtDocumento" type="text" runat="server" Class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblDireccion" runat="server" Text="Direccion"></asp:Label>
                            <asp:TextBox ID="txtDireccion" type="text" runat="server" Class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblCorreo" runat="server" Text="Email"></asp:Label>
                            <asp:TextBox ID="txtCorreo" type="Email" runat="server" Class="form-control"></asp:TextBox>

                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblTelefono" runat="server" Text="Telefono"></asp:Label>
                            <asp:TextBox ID="txtTelefono" type="text" runat="server" Class="form-control"></asp:TextBox>
                        </div>
                       
                        <div>

                            <asp:Button ID="btnGuardarCliente" runat="server" OnClick="btnGuardarCliente_Click" Class="btn btn-success" Text="Guardar" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script type="text/javascript">
        $(document).on('click', '.panel-heading span.clickable', function (e) {
            var $this = $(this);
            if (!$this.hasClass('panel-collapsed')) {
                $this.parents('.panel').find('.panel-body').slideUp();
                $this.addClass('panel-collapsed');
                $this.find('i').removeClass('glyphicon-chevron-up').addClass('glyphicon-chevron-down');
            } else {
                $this.parents('.panel').find('.panel-body').slideDown();
                $this.removeClass('panel-collapsed');
                $this.find('i').removeClass('glyphicon-chevron-down').addClass('glyphicon-chevron-up');
            }
        })
    </script>
</asp:Content>
