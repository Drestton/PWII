<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarTurno.aspx.cs" Inherits="Presentacion.EditarTurno" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="card w-75">
            <div class="card-body">
                <div class="row">
                    <div class="col-md-6">
                        <h3>Modificacion de Turno
                        </h3>

                        <div class="form-group">
                            <asp:Label ID="lblCliente" runat="server" Text="">Cliente: </asp:Label>
                            <asp:Label ID="lblNombreApellido" runat="server" Text=""></asp:Label>
                            <asp:Label ID="lblDNI" runat="server" Text=""></asp:Label>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="lblFecha" runat="server" Text="Fecha"></asp:Label>
                            <div class="input-group date">
                                <asp:TextBox ID="txtFecha" runat="server" Class="form-control"></asp:TextBox>
                                <div class="input-group-addon">
                                    <span class="glyphicon glyphicon-th"></span>
                                </div>
                            </div>
                        </div>

                        <div class="form-group">
                            <h4>Cancha</h4>
                            <asp:DropDownList ID="ddlCancha" CssClass="btn btn-default btn" AutoPostBack="true" runat="server" DataTextField="idCancha" DataValueField="idCancha"></asp:DropDownList>
                            <br />
                        </div>

                        <div class="form-group">
                            <asp:Label ID="lblFranjaHoraria" runat="server" Text="Franja Horaria"></asp:Label>
                            <asp:DropDownList ID="ddlFranjaHoraria" runat="server" Class="form-control">
                                <asp:ListItem Text="Seleccionar" Value="Seleccionar"></asp:ListItem>
                                <asp:ListItem Text="Mañana" Value="Mañana"></asp:ListItem>
                                <asp:ListItem Text="Tarde" Value="Tarde"></asp:ListItem>
                                <asp:ListItem Text="Noche" Value="Noche"></asp:ListItem>
                            </asp:DropDownList>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="lblEstado" runat="server" Text="Estado"></asp:Label>
                            <asp:DropDownList ID="ddlEstado" runat="server" Class="form-control">
                                <asp:ListItem Text="Seleccionar" Value="Seleccionar"></asp:ListItem>
                                <asp:ListItem Text="Libre" Value="Libre"></asp:ListItem>
                                <asp:ListItem Text="Ocupado" Value="Ocupado"></asp:ListItem>
                            </asp:DropDownList>
                        </div>

                        <div>
                            <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Class="btn btn-success" Text="Guardar Modificacion" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script type="text/javascript">
        $('.date').datepicker({
            format: 'mm/dd/yyyy',
            startDate: '-3d'
        })
    </script>
</asp:Content>
