<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeUI.aspx.cs" Inherits="EmployeeInfoWebApp.UI.EmployeeUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Records Entry UI</title>
    <link href="../bootstrap-3.3.6/dist/css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="row">
            <div class="col-md-12">
                <div class="col-lg-2">
                </div>
                <div class="col-lg-8">
                    <label>Employee Records Entry From</label>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="col-lg-2">
                </div>
                <div class="col-md-2">
                    <div class="form-group">
                        <label>First Name :</label>
                        <asp:TextBox runat="server" ID="firstNameTextBox" MaxLength="30" CssClass="form-control" TabIndex="1"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="col-lg-2">
                </div>
                <div class="col-md-2">
                    <div class="form-group">
                        <label>Middle Name :</label>
                        <asp:TextBox runat="server" ID="middleNameTextBox" MaxLength="30" CssClass="form-control" TabIndex="2"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="col-lg-2">
                </div>
                <div class="col-md-2">
                    <div class="form-group">
                        <label>Last Name :</label>
                        <asp:TextBox runat="server" ID="lastNameTextBox" MaxLength="30" CssClass="form-control" TabIndex="3"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="col-md-2">
                </div>
                <div class="col-md-2">
                    <asp:Button ID="submitButton" runat="server" Text="Save" CssClass="btn btn-primary" OnClick="submitButton_Click" />
                    <asp:Button ID="refreshButton" runat="server" Text="Refresh" CssClass="btn btn-danger" OnClick="refreshButton_Click" />
                    <asp:Button ID="showlButton" runat="server" Text="Show" CssClass="btn btn-info" OnClick="showlButton_Click" />
                </div>
                <div class="col-md-2">
                    <label id="messageLabel" runat="server"></label>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="col-lg-2">
                </div>
                <div class="col-lg-8">
                    <label id="empRecInfo" runat="server">Employee Records Information :</label>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="col-lg-2">
                </div>
                <div class="col-lg-8">
                    <asp:Panel ID="pnlEmpRec" runat="server">
                        <div style="height: 350px; overflow: scroll; width: 940px" class="gridBorder">
                            <asp:GridView ID="showEmpGridView" CssClass="table table-bordered" DataKeyNames="Id" runat="server" AutoGenerateColumns="False" OnPageIndexChanging="showEmpGridView_PageIndexChanging"
                                OnRowCancelingEdit="showEmpGridView_RowCancelingEdit" OnRowDeleting="showEmpGridView_RowDeleting" OnRowEditing="showEmpGridView_RowEditing" OnRowUpdating="showEmpGridView_RowUpdating">
                                <Columns>
                                    <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                                    <asp:BoundField DataField="MiddleName" HeaderText="Middle Name" />
                                    <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                                    <asp:CommandField ButtonType="Button" ShowEditButton="True" HeaderText="Edit" />
                                    <asp:CommandField ButtonType="Button" ShowDeleteButton="True" HeaderText="Delete" />
                                </Columns>
                            </asp:GridView>
                        </div>
                    </asp:Panel>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
