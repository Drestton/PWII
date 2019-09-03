<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarTurno.aspx.cs" Inherits="Presentacion.ListarTurno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h1>Listado de Turnos</h1>

            <asp:GridView ID="GridViewTablaTurno" AutoGenerateColumns="false" runat="server" DataKeyNames="turnos_Id" Class="table table-striped table-bordered">
                <Columns>
                    <asp:BoundField DataField="turnos_Id" HeaderText="ID" />
                    <asp:BoundField DataField="idCliente" HeaderText="Nombre de Reserva" />
                    <asp:BoundField DataField="fecha" HeaderText="Fecha" />                    
                    <asp:BoundField DataField="franjaHoraria" HeaderText="Franja Horaria" />
                    <asp:BoundField DataField="estado" HeaderText="Estado" />
                    <asp:TemplateField ShowHeader="false">
                        <ItemTemplate>
                           <asp:Button ID="lnkDelete" OnCommand="lnkDelete_Command"  runat="server" Text="Borrar" CommandArgument='<%# Eval("turnos_Id") %>' CssClass="btn btn-danger" CommandName="lnkBorrar" Font-Underline="false" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

            </asp:GridView>

        </div>
    </div>

</asp:Content>
