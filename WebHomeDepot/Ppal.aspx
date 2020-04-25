<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ppal.aspx.cs" Inherits="WebHomeDepot.Ppal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

    <%--<link href="https://fonts.googleapis.com/css?family=Roboto&display=swap" rel="stylesheet">--%>
    <link href="scripts/plupload/js/jquery.plupload.queue/css/jquery.plupload.queue.css" rel="stylesheet" />
    <link href="Recursos/css/all.css" rel="stylesheet" />

    <%--INICIO DE PARCHE--%>
    <link href="Recursos/gridBT/bootstrap.min.css" rel="stylesheet" />
    <link href="Recursos/gridBT/all.min.css" rel="stylesheet" />
    <link href="Recursos/gridBT/ui.jqgrid-bootstrap4.css" rel="stylesheet" />

    <script src="Recursos/gridBT/jquery-2.2.0.min.js"></script>
    <script src="Recursos/gridBT/jquery-ui.min.js"></script>
    <script src="Recursos/gridBT/bootstrap.min.js"></script>
    <script src="Recursos/gridBT/jquery.jqGrid.min.js"></script>
    <script src="Recursos/gridBT/popper.min.js"></script>
    <script src="scripts/i18n/grid.locale-es.js"></script>
    <script src="Recursos/gridBT/jquery.jqGrid.min.js"></script>
    <%--FIN DE PARCHE--%>


    <script src="scripts/plupload/js/plupload.full.min.js"></script>
    <script src="scripts/plupload/js/jquery.plupload.queue/jquery.plupload.queue.min.js"></script>
    <script src="scripts/plupload/js/i18n/es.js"></script>

    <script src="scripts/master.js"></script>

    <style>
        body {
            /*font-family: 'Roboto', 'sans-serif';*/
            /*font-size: 14px;*/
        }

        #cMain {
            margin: 10px;
        }

        /* Rimpicciolisco i caratteri */
        .ui-jqgrid {
            font-size: 0.9rem;
        }

            /* Aggiungo il padding alla destra della cella */
            .ui-jqgrid .ui-jqgrid-btable tbody tr.jqgrow td {
                padding-right: 0.75rem;
            }
        /* char wrap */
        th.ui-th-column div {
            word-wrap: break-word;
            white-space: -moz-pre-wrap;
            white-space: -pre-wrap;
            white-space: -o-pre-wrap;
            white-space: pre-wrap;
            overflow: hidden;
            height: auto !important;
            vertical-align: middle;
        }

        /* word wrap */
        .ui-jqgrid tr.jqgrow td {
            white-space: normal !important;
            height: auto;
            vertical-align: middle;
            padding-top: 2px;
            padding-bottom: 2px;
        }


        /* gestione char wrap e word wrap anche in caso di colonne frozen */
        .ui-jqgrid .ui-jqgrid-htable th.ui-th-column {
            padding-top: 2px;
            padding-bottom: 2px;
        }

        .ui-jqgrid .frozen-bdiv, .ui-jqgrid .frozen-div {
            overflow: hidden;
        }

        /*.ui-jqgrid tr.jqgrow td {
            font-size: 0.8em;
        }

        .ui-jqgrid td.jqgrow td {
            font-size: 0.9em;
        }*/
    </style>
</head>
<body>
    <div class="container">
        <nav class="navbar navbar-expand-lg navbar-light bg-light">
            <a class="navbar-brand" href="#">Navbar</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>

            <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul class="navbar-nav mr-auto">
                    <li class="nav-item active">
                        <a class="nav-link" href="#">Home <span class="sr-only">(current)</span></a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Link</a>
                    </li>
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Archivos
                        </a>
                        <div class="dropdown-menu" aria-labelledby="navbarDropdown">
                            <a id="aOrdenes" class="dropdown-item" href="#">Ver Ordenes de Venta (.xml)</a>
                            <a id="aProcesados" class="dropdown-item" href="#"><i class="text-primary fas fa-file-excel"></i>Ver Procesados (.xls)</a>
                            <div class="dropdown-divider"></div>
                            <a class="dropdown-item" href="#">Ver Publicados (.xls)</a>
                        </div>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link disabled" href="#" tabindex="-1" aria-disabled="true">Disabled</a>
                    </li>
                </ul>
                <form class="form-inline my-2 my-lg-0">
                    <input class="form-control mr-sm-2" type="search" placeholder="Vendedor" aria-label="Search" value="Pancho Pistolas" disabled />
                    <button class="btn btn-outline-success my-2 my-sm-0" type="submit">Salir</button>
                </form>
            </div>
        </nav>
        <br />
        <br />
        <%--<div style="margin-left: 20px;">--%>

        <div id="dvGrid" class="table-responsive">
            <br />
            <br />

            <table id="jqGrid" class="table table-bordered table-hover" style="font-family: 'Roboto' ,'Arial';"></table>
            <div id="jqGridPager"></div>
            <br />
            <br />

        </div>

        <br />
        <div class="form-group row">
            <label for="txtExcel" class="col-sm-2 col-form-label">Nombre Archivo Excel:</label>
            <div class="col-sm-6">
                <input type="text" class="form-control-plaintext  border-bottom" aria-describedby="emailHelp borde" id="txtExcel" placeholder="Escriba Nombre Excel...">
                <small id="emailHelp" class="form-text text-muted">Nombre del Archivo con extensión (.xls) o (.xlsx)</small>
            </div>
        </div>
        <%-- 
            <div class="form-group">
                <label for="txtExcel">Nombre Excel</label>
                <input type="text" class="form-control" id="txtExcel" aria-describedby="emailHelp" placeholder="Nombre Excel">
                <small id="emailHelp" class="form-text text-muted">Nombre del Archivo con extensión</small>
            </div>--%>
        <br />
        <br />
        <%--<input id="btListaVendedor" class="btn btn-info" type="button" value="Lista Vendedor" />--%>
        <button id="btProcesar" type="button" class="btn btn-lg btn-outline-info"><i class='fas fa-cogs'></i>&nbspProcesar</button>
        <%--<input id="btProcesar" class="btn btn-outline-info" type="button" value="<i class='fas fa-cogs'></i>Procesar"/>--%>
        <%--<input id="btListar" class="btn btn-info" type="button" value="Listar Archivos" />--%>
        <%-- <input id="btBajada" class="btn btn-info" type="button" value="Bajar Archivos" />--%>
        <input id="btSubirArchi" class="btn btn-info" type="button" value="Subir Archivos" />
        <input id="btRefrescar" class="btn btn-info" type="button" value="Refrescar" />
        <button type="button" class="btn btn-primary fa fa-bank">Primary</button>
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

        <!-- Modal Archivos Excel -->
        <div class="modal fade" id="mdCreadosExcel" role="dialog">
            <div class="modal-dialog modal-xl">
                <div class="modal-content">
                    <div class="modal-header">
                        <h4 class="modal-title">Excel Creados</h4>
                        <button type="button" class="close" data-dismiss="modal">&times;</button>

                    </div>
                    <div class="modal-body">
                       <%-- <div class="container">--%>
                            <table id="jgCreados" class="table table-bordered table-hover" style="font-family: 'Roboto' ,'Arial';"></table>
                            <div id="jgCreadosPager"></div>
                       <%-- </div>--%>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
                    </div>
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
</body>
</html>
