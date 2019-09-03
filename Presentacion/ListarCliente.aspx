<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarCliente.aspx.cs" Inherits="Presentacion.ListarCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h1>Listado de Clientes</h1>
            <asp:GridView ID="GridViewTablaCliente" AutoGenerateColumns="False" runat="server" DataKeyNames="IdCliente" class="table table-striped table-bordered">
                <Columns>
                    <asp:BoundField DataField="IdCliente" HeaderText="ID" />
                    <asp:BoundField DataField="nombreApellido" HeaderText="Nombre y Apellido" />
                    <asp:BoundField DataField="edad" HeaderText="Edad" />
                    <asp:BoundField DataField="documento" HeaderText="Documento" />
                    <asp:BoundField DataField="direccion" HeaderText="Direccion" />
                    <asp:BoundField DataField="correoElectronico" HeaderText="Email" />
                    <asp:BoundField DataField="telefono" HeaderText="Telefono" />
                    <asp:TemplateField ShowHeader="false">
                        <ItemTemplate>
                            <asp:Button ID="lnkEdit" OnCommand="lnkEdit_Command" runat="server" Text="Editar" CommandArgument='<%# Eval("IdCliente") %>' CssClass="btn btn-warning" CommandName="lnkEditar" Font-Underline="false" />
                            <asp:Button ID="lnkDelete" OnCommand="lnkDelete_Command" runat="server" Text="Borrar" CommandArgument='<%# Eval("IdCliente") %>' CssClass="btn btn-danger" CommandName="lnkBorrar" Font-Underline="false" />
                            <asp:Button ID="lnkReservar" OnCommand="lnkReservar_Command"  runat="server" Text="Reservar Turno" CommandArgument='<%# Eval("IdCliente") %>' CssClass="btn btn-primary" CommandName="lnkReservar" Font-Underline="false" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
