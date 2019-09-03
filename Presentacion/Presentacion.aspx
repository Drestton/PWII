<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Presentacion.aspx.cs" Inherits="Presentacion.Presentacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="jumbotron">
  <h1>Bienvenido al sistema</h1>
    <p class="lead">Sistema de gestion de clientes, canchas y turnos. Utiliza la barra de navegacion para acceder a todas las opciones.</p>
    <p><a class="btn btn-lg btn-danger" href="FormularioCliente.aspx" role="button">Cargar un cliente</a></p>
        <p><a class="btn btn-lg btn-danger" href="ReservarTurno.aspx" role="button">Reservar un Turno</a></p>
        <p><a class="btn btn-lg btn-danger" href="FormularioCancha.aspx" role="button">Cargar una Cancha</a></p>
    </div>

    <div class="row marketing">
    <div class="col-lg-6">
        <h4>Cargar Cliente</h4>
        <p>Esta seccion le permitira cargar un cliente para asignarle un turno.</p>

        <h4>Listar Clientes</h4>
        <p>En esta seccion aparecen todos los clientes que esten cargados en la base de datos.</p>
    </div>

    <div class="col-lg-6">
        <h4>Editar Informacion</h4>
        <p>Esta seccion permite editar la informacion ya cargada de un cliente.</p>

        <h4>Listar Turnos</h4>
        <p>Esta seccion esta dedicada para ver un listado de todos los turnos.</p>
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
