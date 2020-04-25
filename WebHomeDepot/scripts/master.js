$(document).ready(function () {

    var dvGridClon = null;
    var mdInsertExcelClon = null;
    var gridXml = null;
    var carpetaExcelSession = null;
    //$.jgrid.defaults.width = 600;
    $.jgrid.defaults.responsive = true;
    $.jgrid.defaults.styleUI = 'Bootstrap4';
    //$.jgrid.defaults.iconSet = "Octicons";
    $.jgrid.defaults.iconSet = "fontAwesome";
    //$.jgrid.defaults.iconSet = "Iconic";
    (function () {
   
        //var datos = new Object();
        //datos.codVendedor = "0";
        //datos.rutaArchivo = "COLECTOR";

        //$.post("ListadorArchivos.ashx?accion=enviar", JSON.stringify(datos), function (data) {
        //    mydata = data;
        //    llenarGridXml();
        //});

        //clonarGrid();
        //clonarModal();

        listarArchivos();

    }());
    
    function listarArchivos() {

        var datos = new Object();
        datos.codVendedor = codigoVendedor; //"0";
        datos.rutaArchivo = "COLECTOR";

        $.post("ListadorArchivos.ashx?accion=enviar", JSON.stringify(datos), function (data) {
            mydata = data;
            llenarGridXml();
        });
    }

    $("#btAdicionar").click(function (e) {

        e.preventDefault();

        $("#mdInsertExcel").modal("show");
    });
    
    $("#aOrdenes").click(function () {

        //listarArchivos();
        //var datos = new Object();
        //datos.codVendedor = "0";
        //datos.rutaArchivo = "COLECTOR";

        //$.post("ListadorArchivos.ashx?accion=enviar", JSON.stringify(datos), function (data) {
        //    mydata = data;
        //    llenarGridXml();
        //});

    });

    $("#aProcesados").click(function () {

        var datos = new Object();
        datos.codVendedor = "0";
        datos.rutaArchivo = "PROCESADOS";
        carpetaExcelSession = "PROCESADOS";

        $.post("ListadorArchivos.ashx?accion=enviar", JSON.stringify(datos), function (data) {

            
            $("#mdCreadosExcel").modal('show');
           
            mydataXls = data;
           
        });

        $('#mdCreadosExcel').on('shown.bs.modal', function (e) {
            llenarGridXls();
        })
    });

    $("#aPublicados").click(function () {

        var datos = new Object();
        datos.codVendedor = "0";
        datos.rutaArchivo = "PUBLICADOS";
        carpetaExcelSession = "PUBLICADOS";

        $.post("ListadorArchivos.ashx?accion=enviar", JSON.stringify(datos), function (data) {


            $("#mdCreadosExcel").modal('show');

            mydataXls = data;

        });

        $('#mdCreadosExcel').on('shown.bs.modal', function (e) {
            llenarGridXls();
        })
    });
    
    $("#btProcesar").click(function () {

        var grid = $("#jqGrid");
        //var rowKey = grid.getGridParam("selrow");
        var rowKey = $("#jqGrid").jqGrid("getGridParam", "selrow");
        var lista = new Array();

        var nombreArchivo = $("#txtExcel").val();

        if (nombreArchivo == "") {
            alert("Debe indicar un nombre de Archivo Excel");
            return;
        }

        if (!rowKey)
            alert("No hay filas seleccionadas.");
        else {
            //var selectedIDs = grid.getGridParam("selarrrow");
            var selectedIDs = $("#jqGrid").jqGrid("getGridParam", "selarrrow"); //grid.getGridParam("selarrrow");
            var result = "";
            for (var i = 0; i < selectedIDs.length; i++) {
                result += selectedIDs[i] + ",";
                var archi = $("#jqGrid").jqGrid("getRowData", selectedIDs[i]);   //grid.getRowData(selectedIDs[i]);  //jQuery('#grid').jqGrid('getRowData', rowid);
                var nm = archi.nombre;
                lista.push(nm);
            }

            var datos = new Object();
            datos.nombreExcel = nombreArchivo;
            datos.lstArchivos = lista;

            $.post("Procesador.ashx?accion=enviar", JSON.stringify(datos), function () {

                listarArchivos();

                alert("Proceso terminado");

            });

            //alert(result);
        }

    });

    $("#btListar").click(function () {

        var datos = new Object();
        datos.codVendedor = "Juan";
        datos.rutaArchivo = "ruta de Archivo";

        $.post("ListadorArchivos.ashx?accion=enviar", JSON.stringify(datos), function (data) {
            alert(data);
        });
    });
        
    $("#btBajada").click(function () {

        var grid = $("#jqGrid");
        //var rowKey = grid.getGridParam("selrow");
        var rowKey = $("#jqGrid").jqGrid("getGridParam", "selrow");
        if (!rowKey){
            alert("No hay archivos seleccionados");
            return;
        }
        //else {

            var selectedIDs = grid.getGridParam("selarrrow");
            var result = "";
            for (var i = 0; i < selectedIDs.length; i++) {
               
                //var archi = grid.getRowData(selectedIDs[i]);  //jQuery('#grid').jqGrid('getRowData', rowid);
                var archi = $("#jqGrid").jqGrid("getRowData", selectedIDs[i]);
                var nm = archi.nombre;

                //var datos = new Object();
                //datos.codVendedor = nm;
                //datos.rutaArchivo = "";

                $("#txtArchivo").val(nm);
                $("#btBajadorTblCsv").trigger("click");

                //$.post("BajadorArchi.ashx?accion=enviar", JSON.stringify(datos), function (data) {
                //    //alert(data);
                //});
            }
      
        
        //$.post("BajadorArchi.ashx?accion=enviar", JSON.stringify(datos), function (data) {
        //    alert(data);
        //});

    });

    $("#btSubirArchi").click(function (e) {
        e.preventDefault;

        $("#myModal").modal('show');

        // Setup html5 version
        $("#uploader").pluploadQueue({
            // General settings
            runtimes: 'html5,flash,silverlight,html4',

            // Fake server response here 
            // url : '../upload.php',
            url: "SubidorArchi.ashx?accion=enviar",

            max_file_size: '100mb',
            chunks: {
                size: '100mb', //Troza los archivos en paquetes
                send_chunk_number: false // set this to true, to send chunk and total chunk numbers instead of offset and total bytes
            },
            rename: true,
            dragdrop: true,
            filters: [
                //{ title: "Archivo Imagenes", extensions: "jpg,gif,png, jpeg" },
                { title: "Archivos Zip", extensions: "xls,xlsx" },
                { title: "Archivos csv", extensions: "xml" }
                //{ title: "Archivos texto", extensions: "txt" },
                //{ title: "Archivos html", extensions: "html" }
            ],
            // Views to activate
            views: {
                list: true,
                thumbs: true, // Show thumbs
                active: 'thumbs'
            },
            // Resize images on clientside if we can
            //resize: {width: 320, height: 240, quality: 90},

            flash_swf_url: 'scripts/plupload/js/Moxie.swf', //'http://rawgithub.com/moxiecode/moxie/master/bin/flash/Moxie.cdn.swf',
            silverlight_xap_url: 'scripts/plupload/js/Moxie.xap' //'http://rawgithub.com/moxiecode/moxie/master/bin/silverlight/Moxie.cdn.xap'
        });
    });

    $("#btRefrescar").click(function () {
        var datos = new Object();
        datos.codVendedor = "0";
        datos.rutaArchivo = "COLECTOR";

        $.post("ListadorArchivos.ashx?accion=enviar", JSON.stringify(datos), function (data) {
            mydata = data;
            //llenarGridXml();
            $("#jqGrid").data = mydata;
            $("#jqGrid").trigger('reloadGrid');
        });
        //$("#jqGrid").data = mydata;
    });

    //$('#mdInsertExcel').validate({
    //    rules: {
    //        sku: { required: true },
    //        descripcion: { required: true }
    //    },
    //    messages: {
    //        sku: { required: "Ingrese Descripción" },
    //        descripcion: { required: true }
    //    }
    //});

    function marcarSessionExcel(nombreArchi) {

        $.get("SesionadorArchivo.ashx", { nombre: nombreArchi, carpeta: carpetaExcelSession });
    }

    function llenarGridXml() {

        //$("#dvGridClon").html(dvGridClon);
        
        
        $("#jqGrid").jqGrid(optionXml); 

        var grid = $('#jqGrid');
        //grid.clearGridData();
        $("#jqGrid").jqGrid("clearGridData", true);
        //grid.setGridParam({ data: mydata });
        $("#jqGrid").jqGrid("setGridParam",
            {
                data: mydata,
                datatype: 'local'
            });
        //grid.setGridParam({ datatype: 'local' });
        //$("#jqGrid").jqGrid("setGridParam", 'local');
        $("#jqGrid").trigger('reloadGrid');
        $("#jqGrid").jqGrid('setLabel', 'nombre', '', { 'text-align': 'center' });
    }

    function llenarGridXls() {
       
        $("#jgCreados").jqGrid(optionXls);

        var grid = $('#jgCreados');
        //grid.clearGridData();
        $("#jgCreados").jqGrid("clearGridData", true);
        //grid.setGridParam({ data: mydata });
        $("#jgCreados").jqGrid("setGridParam",
            {
                data: mydataXls,
                datatype: 'local'
            });
        //grid.setGridParam({ datatype: 'local' });
        //$("#jqGrid").jqGrid("setGridParam", 'local');
        $("#jgCreados").trigger('reloadGrid');
        $("#jgCreados").jqGrid('setLabel', 'nombre', '', { 'text-align': 'right' });
    }

    var optionXml = {
        guiStyle: "bootstrap4",
        iconSet: "fontAwesome",
        datatype: "local",
        data: mydata,
        colModel: [
           { label: 'Nombre', name: 'nombre', width: 150, align: 'left' },
           { label: 'Largo', name: 'largo', width: 50, align: 'right' },
           { label: 'Fecha', name: 'fecha', width: 100, align: 'right' },
           { label: 'Bajada', name: 'link', width: 80, align: 'center', formatter: 'showlink' }

        ],
        viewrecords: true, // show the current page, data rang and total records on the toolbar
        multiselect: true,
        width: 750,
        height: 300,
        rowNum: 5,
        loadonce: false, // this is just for the demo
        pager: "#jqGridPager",
        //caption: "Ordenes de Venta solicitadas",
        shrinkToFit: true,
        autowidth: true
    };

    var optionXls = {
        guiStyle: "bootstrap4",
        iconSet: "fontAwesome",
        datatype: "local",
        data: mydataXls,
        colModel: [
           { label: 'Nombre', name: 'nombre', width: 150, align: 'left' },
           { label: 'Largo', name: 'largo', width: 50, align: 'right' },
           { label: 'Fecha', name: 'fecha', width: 100, align: 'right' },
           { label: 'Bajada', name: 'link', width: 80, align: 'center', formatter: 'showlink' }

        ],
        viewrecords: true, // show the current page, data rang and total records on the toolbar
        multiselect: false,
        width: 750,
        height: 300,
        rowNum: 5,
        loadonce: false, // this is just for the demo
        pager: "jgCreadosPager",
       // caption: "Archivos Excel creados desde (.xml)",
        shrinkToFit: true,
        autowidth: true,
        onSelectRow: function (rowid) {

            //Obtener el objeto enlazado
            var archivo = jQuery('#jgCreados').jqGrid('getRowData', rowid);
            var nmArchivo=  archivo["nombre"];
            marcarSessionExcel(nmArchivo);

            $("#iMsj").html(" Carpeta: <b>" + carpetaExcelSession + "</b>, Archivo: <b>" + nmArchivo + "</b>");
        }
    };

    var mydata = [
                  { id: "1", invdate: "2007-10-01", name: "test", note: "note", amount: "200.00", tax: "10.00", total: "210.00" },
                  { id: "2", invdate: "2007-10-02", name: "test2", note: "note2", amount: "300.00", tax: "20.00", total: "320.00" },
                  { id: "3", invdate: "2007-09-01", name: "test3", note: "note3", amount: "400.00", tax: "30.00", total: "430.00" },
                  { id: "4", invdate: "2007-10-04", name: "test", note: "note", amount: "200.00", tax: "10.00", total: "210.00" },
                  { id: "5", invdate: "2007-10-05", name: "test2", note: "note2", amount: "300.00", tax: "20.00", total: "320.00" },
                  { id: "6", invdate: "2007-09-06", name: "test3", note: "note3", amount: "400.00", tax: "30.00", total: "430.00" },
                  { id: "7", invdate: "2007-10-04", name: "test", note: "note", amount: "200.00", tax: "10.00", total: "210.00" },
                  { id: "8", invdate: "2007-10-03", name: "test2", note: "note2", amount: "300.00", tax: "20.00", total: "320.00" },
                  { id: "9", invdate: "2007-09-01", name: "test3", note: "note3", amount: "400.00", tax: "30.00", total: "430.00" }
    ];

    var mydataXls = [
                 { id: "1", invdate: "2007-10-01", name: "test", note: "note", amount: "200.00", tax: "10.00", total: "210.00" },
                 { id: "2", invdate: "2007-10-02", name: "test2", note: "note2", amount: "300.00", tax: "20.00", total: "320.00" },
                 { id: "3", invdate: "2007-09-01", name: "test3", note: "note3", amount: "400.00", tax: "30.00", total: "430.00" },
                 { id: "4", invdate: "2007-10-04", name: "test", note: "note", amount: "200.00", tax: "10.00", total: "210.00" },
                 { id: "5", invdate: "2007-10-05", name: "test2", note: "note2", amount: "300.00", tax: "20.00", total: "320.00" },
                 { id: "6", invdate: "2007-09-06", name: "test3", note: "note3", amount: "400.00", tax: "30.00", total: "430.00" },
                 { id: "7", invdate: "2007-10-04", name: "test", note: "note", amount: "200.00", tax: "10.00", total: "210.00" },
                 { id: "8", invdate: "2007-10-03", name: "test2", note: "note2", amount: "300.00", tax: "20.00", total: "320.00" },
                 { id: "9", invdate: "2007-09-01", name: "test3", note: "note3", amount: "400.00", tax: "30.00", total: "430.00" }
    ];
});
