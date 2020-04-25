<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="EditorExcel.aspx.cs" Inherits="WebHomeDepot.EditorExcel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <%--   <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="scripts/bootstrap.min.js"></script>--%>

    <%--<link rel="stylesheet" crossorigin="anonymous"
        href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.1.3/css/bootstrap.min.css"
        integrity="sha256-eSi1q2PG6J7g7ib17yAaWMcrr5GrtohYChqibrV7PBE=">--%>
    <link href="Recursos/css/bootstrap.min.css" rel="stylesheet" />

    <%-- <link rel="stylesheet" crossorigin="anonymous"
        href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"
        integrity="sha256-eZrrJcwDc/3uDhsdt61sL2oOBY362qM3lon1gyExkL0=">--%>
    <link href="Recursos/css/all.css" rel="stylesheet" />

    <link rel="stylesheet" crossorigin="anonymous"
        href="https://cdnjs.cloudflare.com/ajax/libs/free-jqgrid/4.15.5/css/ui.jqgrid.min.css"
        integrity="sha256-3oIi71IMpsoA+8ctSTIM+6ScXYjyZEV06q6bbK6CjsM=">
    <script crossorigin="anonymous" src="https://code.jquery.com/jquery-3.3.1.min.js"
        integrity="sha256-FgpCb/KJQlLNfOu91ta32o/NMZxltwRo8QtmkMRdAu8="></script>
    <script crossorigin="anonymous"
        src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"
        integrity="sha256-98vAGjEDGN79TjHkYWVD4s87rvWkdWLHPs5MC3FvFX4="></script>

    <%--<script crossorigin="anonymous"
        src="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.1.3/js/bootstrap.min.js"
        integrity="sha256-VsEqElsCHSGmnmHXGQzvoWjWwoznFSZc6hs7ARLRacQ="></script>--%>

    <script src="Recursos/js/bootstrap.min.js"></script>

    <script src="scripts/i18n/grid.locale-es.js"></script>

    <script src="Recursos/gridBT/jquery.jqGrid.min.js"></script>
    <script src="scripts/master.js"></script>

    <script type="text/javascript">

        function ShowPopup() {

            $("#myModal").modal('show');

        }

    </script>

    <style>
        td {
            width: 100px;
        }

        .celda {
            padding: 0px;
        }
    </style>

</head>
<body>

    <div class="container">
        <%--<form id="form1" runat="server">--%>
            <div class="table-responsive">
                <asp:GridView ID="GridView1" runat="server"
                    Font-Names="Tahoma"
                    AutoGenerateColumns="False" DataSourceID="ObjectDataSource1"
                    CssClass="table table-bordered thead-light table-striped table-hover" Font-Size="Smaller"
                    AllowPaging="True" ShowFooter="True" Width="1000px">
                    <Columns>
                        <asp:TemplateField HeaderText="Linea" SortExpression="linea">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("linea") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("linea") %>'></asp:Label>
                            </ItemTemplate>
                            <ControlStyle Width="35px" />
                            <HeaderStyle Width="25px" />
                            <ItemStyle Width="25px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="SKU" SortExpression="SKU">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("SKU") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("SKU") %>'></asp:Label>
                            </ItemTemplate>
                            <ControlStyle Width="70px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Descripcion" SortExpression="Descripcion">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Descripcion") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("Descripcion") %>'></asp:Label>
                            </ItemTemplate>
                            <ControlStyle Width="150px" />
                            <HeaderStyle Width="150px" />
                            <ItemStyle Width="150px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Cantidad" SortExpression="CANT">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("CANT") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label4" runat="server" Text='<%# Bind("CANT") %>'></asp:Label>
                            </ItemTemplate>
                            <ControlStyle Width="30px" />
                            <HeaderStyle Width="30px" />
                            <ItemStyle HorizontalAlign="Right" Width="30px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Tienda" SortExpression="TIENDA">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("TIENDA") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label5" runat="server" Text='<%# Bind("TIENDA") %>'></asp:Label>
                            </ItemTemplate>
                            <ControlStyle Width="50px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Orden Compra" SortExpression="OC">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("OC") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label6" runat="server" Text='<%# Bind("OC") %>'></asp:Label>
                            </ItemTemplate>
                            <ControlStyle Width="70px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Costo Unitario" SortExpression="CostoUnitario">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("CostoUnitario") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label7" runat="server" Text='<%# Bind("CostoUnitario") %>'></asp:Label>
                            </ItemTemplate>
                            <ControlStyle Width="50px" />
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Fill01" SortExpression="Fill01">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox8" runat="server" Text='<%# Bind("Fill01") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label8" runat="server" Text='<%# Bind("Fill01") %>'></asp:Label>
                            </ItemTemplate>
                            <ControlStyle Width="100px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Fill02" SortExpression="Fill02">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox9" runat="server" Text='<%# Bind("Fill02") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label9" runat="server" Text='<%# Bind("Fill02") %>'></asp:Label>
                            </ItemTemplate>
                            <ControlStyle Width="100px" />
                        </asp:TemplateField>
                        <asp:TemplateField ShowHeader="False">
                            <EditItemTemplate>
                                <div class="btn-group" role="group">
                                    <asp:LinkButton ID="LinkButton1" CssClass="btn btn-outline-info" runat="server" CausesValidation="True" CommandName="Update" ToolTip="Actualizar"><i class='far fa-check-circle'></i></asp:LinkButton>
                                    <asp:LinkButton ID="LinkButton2" CssClass="btn btn-outline-info" runat="server" CausesValidation="False" CommandName="Cancel" ToolTip="Cancelar"><i class='far fa-times-circle'></i></asp:LinkButton>
                                </div>
                            </EditItemTemplate>
                            <FooterTemplate>
                                <%--<asp:LinkButton ID="Button2" OnClick="Button2_Click" CssClass="btn btn-outline-info" runat="server" ToolTip="Adicionar"><i class='far fa-plus-square'></i></asp:LinkButton>--%>
                            </FooterTemplate>
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" CssClass="btn btn-outline-info" runat="server" CausesValidation="False" CommandName="Edit"><i class='far fa-edit'></i></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <%--<PagerSettings Mode="NextPreviousFirstLast"  PageButtonCount="8" FirstPageText="Primero"/>--%>
                    <EditRowStyle Width="100px" />
                    <PagerSettings FirstPageText=" Primera" LastPageText="Ultima" NextPageText="Siguiente" PreviousPageText="Previa" />
                </asp:GridView>
            </div>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"
                SelectMethod="getExcelList" TypeName="WebHomeDepot.clases.getExcelLayer"
                UpdateMethod="updateExcel" DataObjectTypeName="WebHomeDepot.clases.ExcelVO"></asp:ObjectDataSource>


            <div class="form-group mb-2">
                <label for="staticEmail2" class="sr-only">Email</label>
                <input type="text" readonly class="form-control-plaintext" id="staticEmail2" value="Nombre de Publicación:" style="width: 200px;" />
            </div>

            <div class="form-group mx-sm-3 mb-2">
                <label for="txtArchi" class="sr-only">Password</label>
                <asp:TextBox ID="txtArchi" runat="server" CssClass="form-control" Width="200px" />

            </div>
            <asp:Button ID="btAdicionar" CssClass="btn btn-outline-info" runat="server" Text="Adicionar Registro" />
            <asp:Button ID="Button1" CssClass="btn btn-outline-info" runat="server" OnClick="Button1_Click" Text="Publicar Excel" />
            <%-- <asp:Button ID="btnShowPopup" runat="server" Text="Button" class="btn btn-primary btn-lg" data-toggle="modal" data-target="#myModal" />--%>

            <div class="modal fade" id="myModal">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-header">

                            <h4 class="modal-title">
                                <asp:Label ID="lblTitlePopUp" runat="server" Text="Label"></asp:Label>
                            </h4>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span></button>
                        </div>
                        <div class="modal-body">
                            <div class="col-sm-4">
                                <%--<img src="res/img1.png" width="174" />--%>
                            </div>
                            <div class="col-sm-8">
                                <asp:Label ID="lblMessage" runat="server" />
                            </div>

                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-default" data-dismiss="modal">
                                Close</button>
                        </div>
                    </div>
                    <!-- /.modal-content -->
                </div>
                <!-- /.modal-dialog -->
            </div>
            <!-- /.modal -->


            <div id="mdInsertExcel" class="modal" tabindex="-1" role="dialog">
                <div class="modal-dialog modal-lg" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title">Adicionar Registro a Excel</h5>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            <div class="form-row">
                                <div class="col">
                                    <div class="form-group">
                                        <label for="txtSKU">SKU:</label>
                                        <asp:TextBox ID="txtSKU" class="form-control" runat="server"></asp:TextBox>
                                        <%--<input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Enter email">--%>
                                        <%--<small id="emailHelp" class="form-text text-muted">Clave que indentifica el Producto</small>--%>
                                    </div>

                                    <div class="form-group">
                                        <label for="txtDescripcion">Descripción:</label>
                                        <asp:TextBox ID="txtDescripcion" class="form-control" runat="server"></asp:TextBox>
                                        <%--<input type="password" class="form-control" id="exampleInputPassword1" placeholder="Password">--%>
                                    </div>

                                    <div class="form-group form-check" style="padding-left: 2px; border-left: 2px;">
                                        <label for="txtCantidad">Cantidad:</label>
                                        <asp:TextBox ID="txtCantidad" class="form-control" runat="server"></asp:TextBox>
                                        <%--<input type="checkbox" class="form-check-input" id="exampleCheck1">--%>
                                    </div>


                                    <div class="form-group form-check" style="padding-left: 2px; border-left: 2px;">
                                        <label for="txtTienda">Tienda:</label>
                                        <asp:TextBox ID="txtTienda" class="form-control" runat="server"></asp:TextBox>
                                        <%--<input type="checkbox" class="form-check-input" id="exampleCheck1">--%>
                                    </div>
                                </div>
                                <div class="col">
                                    <div class="form-group form-check" style="padding-left: 2px; border-left: 2px;">
                                        <label for="txtOc">Orden de Compra:</label>
                                        <asp:TextBox ID="txtOc" class="form-control" runat="server"></asp:TextBox>
                                        <%--<input type="checkbox" class="form-check-input" id="exampleCheck1">--%>
                                    </div>
                                    <div class="form-group form-check" style="padding-left: 2px; border-left: 2px;">
                                        <label for="txtCostoUnitario">Costo Unitario:</label>
                                        <asp:TextBox ID="txtCostoUnitario" class="form-control" runat="server"></asp:TextBox>
                                        <%--<input type="checkbox" class="form-check-input" id="exampleCheck1">--%>
                                    </div>
                                    <div class="form-group form-check" style="padding-left: 2px; border-left: 2px;">
                                        <label for="txtFill01">Fill01:</label>
                                        <asp:TextBox ID="txtFill01" class="form-control" runat="server"></asp:TextBox>
                                        <%--<input type="checkbox" class="form-check-input" id="exampleCheck1">--%>
                                    </div>
                                    <div class="form-group form-check" style="padding-left: 2px; border-left: 2px;">
                                        <label for="txtFill02">Fill02:</label>
                                        <asp:TextBox ID="txtFill02" class="form-control" runat="server"></asp:TextBox>
                                        <%--<input type="checkbox" class="form-check-input" id="exampleCheck1">--%>
                                    </div>
                                </div>
                            </div>
                            <div class="modal-footer">
                                <%--<asp:Button ID="Button3" runat="server" Text="Button" />--%>
                                <asp:Button ID="btAddExcel" CssClass="btn btn-outline-info" runat="server" Text="Adicionar" />
                                <button type="button" class="btn btn-secondary" data-dismiss="modal">Cerrar</button>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
    </div>
    <%--</form>--%>



        
</body>
</html>
