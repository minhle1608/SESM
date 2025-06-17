<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/quantri.master" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
 <form>
            <textarea name="editor1" id="editor1" style="width: 100%; height: 200px">
                
            </textarea>
            <script>
                // Replace the <textarea id="editor1"> with a CKEditor
                // instance, using default configuration.
                CKEDITOR.replace( 'editor1' );
            </script>
        </form>
</asp:Content>

