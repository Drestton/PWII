<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormularioCancha.aspx.cs" Inherits="Presentacion.FormularioCancha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="card w-75">
            <div class="card-body">
                <div class="row">
                    <div class="col-md-6">
                        <h3>Nueva Cancha
                        </h3>

                        <div class="form-group">
                            <asp:Label ID="dpTipoCancha" runat="server" Text="Seleccione el Tipo de la Cancha"></asp:Label>
                            <asp:DropDownList ID="ddlTipoCancha" runat="server" Class="form-control"></asp:DropDownList>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="lblNumeroCancha" runat="server" Text="Nº Cancha"></asp:Label>
                            <asp:TextBox ID="txtNumeroCancha" type="text" runat="server" Class="form-control"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="dpEstado" runat="server" Text="Seleccione el Estado de la Cancha"></asp:Label>
                            <asp:DropDownList ID="ddlEstado" runat="server" Class="form-control"></asp:DropDownList>
                        </div>
  
                        <div>
                            <asp:Button ID="btnGuardarCancha" runat="server" OnClick="btnGuardarCancha_Click" Class="btn btn-success" Text="Guardar" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
