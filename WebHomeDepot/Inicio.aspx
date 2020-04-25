<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="WebHomeDepot.Inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">

        <br />
        
        <%--<div id="dvGrid" class="table-responsive">--%>
          
            
            <table id="jqGrid" class="table table-bordered table-hover" style="font-family: 'Roboto' ,'Arial';"></table>
            <div id="jqGridPager"></div>
            <br />
            <br />

        <%--</div>--%>

        <br />
        <div class="form-group row">
            <label for="txtExcel" class="col-sm-2 col-form-label">Nombre Archivo Excel:</label>
            <div class="col-sm-6">
                <input type="text" class="form-control-plaintext  border-bottom" aria-describedby="emailHelp borde" id="txtExcel" placeholder="Escriba Nombre Excel...">
                <small id="emailHelp" class="form-text text-muted">Nombre del Archivo con extensión (.xls) o (.xlsx)</small>
            </div>
        </div>

        <br />
        <br />
        <%--<input id="btListaVendedor" class="btn btn-info" type="button" value="Lista Vendedor" />--%>
        <button id="btProcesar" type="button" class="btn btn-lg btn-outline-info"><i class='fas fa-cogs'></i>&nbspProcesar</button>
        <%--<input id="btProcesar" class="btn btn-outline-info" type="button" value="<i class='fas fa-cogs'></i>Procesar"/>--%>
        <%--<input id="btListar" class="btn btn-info" type="button" value="Listar Archivos" />--%>
        <%-- <input id="btBajada" class="btn btn-info" type="button" value="Bajar Archivos" />--%>
        <%--<input id="btSubirArchi" class="btn btn-info" type="button" value="Subir Archivos" />
        <input id="btRefrescar" class="btn btn-info" type="button" value="Refrescar" />
        <button type="button" class="btn btn-primary fa fa-bank">Primary</button>--%>
        <br />
        <br />
        <%--<a href="javascript:window.location='BajadorArchi.ashx?nombre=Prueba.xls'">download</a>--%>
        <%--        </div>--%>

        <!-- Modal Subir Archivos -->
        <div class="modal fade" id="myModal" role="dialog">
            <div class="modal-dialog modal-lg">
                <div class="modal-content">
                    <div class="modal-header">
                        <h4 class="modal-title">Subir Archivos</h4>
                        <button type="button" class="close" data-dismiss="modal">&times;</button>

                    </div>
                    <div class="modal-body">

                        <form method="post" name="file[]" enctype="multipart/form-data" action="/echo/json">
                            <div id="uploader">
                                <p>Su explorador no tiene soporte para Flash, Silverlight or HTML5.</p>
                            </div>

                        </form>

                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
                    </div>
                </div>
            </div>
        </div>

      

    <!-- FORM OCULTO PARA BAJAR ARCHIVOS -->
    <form name="frmArchiSms" action="BajadorArchi.ashx" method="POST">
        <input id="txtArchivo" type="text" name="archivo" value="" style="visibility: hidden;" />
        <%--<input id="txtTabla" type="text" name="tabla" value=""  style="visibility: hidden; "/>--%>
        <input id="btBajadorTblCsv" type="submit" value="Bajar" name="btBajador" style="visibility: hidden;" />
    </form>

</asp:Content>
