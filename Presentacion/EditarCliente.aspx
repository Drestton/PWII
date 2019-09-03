<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarCliente.aspx.cs" Inherits="Presentacion.EditarCliente" %>
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
                        <div class="form-check">
                            
                            <asp:Label ID="LblSocio" runat="server" Text="Asociado"></asp:Label>
                        
                        <div>
                            <asp:CheckBox ID="CbxSi"  runat="server" Text="Si" />
                            
                        </div>
                        </div>
                        <div>

                            <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Class="btn btn-success" Text="Guardar" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>a
</asp:Content>
