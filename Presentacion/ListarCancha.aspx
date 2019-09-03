<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarCancha.aspx.cs" Inherits="Presentacion.ListarCancha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h1>Listado de Canchas</h1>
            <asp:GridView ID="GridViewTablaCancha" AutoGenerateColumns="False" runat="server" DataKeyNames="idCancha" class="table table-striped table-bordered">
                <Columns>
                    <asp:BoundField DataField="idCancha" HeaderText="ID" />
                    <asp:BoundField DataField="tipoCancha" HeaderText="Tipo de Cancha" />
                    <asp:BoundField DataField="numeroCancha" HeaderText="Cancha numero" />
                    <asp:BoundField DataField="estado" HeaderText="Estado" />
                    <asp:TemplateField ShowHeader="false">
                        <ItemTemplate>                            
                           
                            <asp:Button ID="lnkEdit" onCommand="lnkEdit_Command" runat="server" Text="Editar" CommandArgument='<%# Eval("idCancha") %>' CssClass="btn btn-warning" CommandName="lnkEditar" Font-Underline="false"/>
                            <asp:Button ID="lnkDelete" OnCommand="lnkBorrar_Command" runat="server" Text="Borrar" CommandArgument='<%# Eval("idCancha") %>'  CssClass="btn btn-danger" CommandName="lnkBorrar" Font-Underline="false" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>



