using System.ComponentModel.Composition;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace YK.XrmToolBox.CSVImporter
{
    // Do not forget to update version number and author (company attribute) in AssemblyInfo.cs class
    // To generate Base64 string for Images below, you can use https://www.base64-image.de/
    [Export ( typeof ( IXrmToolBoxPlugin ) ),
        ExportMetadata ( "Name" , "CSV Importer" ),
        ExportMetadata ( "Description" , "Update data in the CRM using CSV files" ),
        // Please specify the base64 content of a 32x32 pixels image
        ExportMetadata ( "SmallImageBase64" , "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAJtSURBVFhH5ddLyExxGMfx464IC5QUIUUoLJBkTSzcExYWKCtFeV1CKdfYWJAUFjassEHEQiihyNJGcltQ5J7b9zvvPPk3vWdmzlyi/OrTvOc55/zPM++5/M9kVdILG/EYX/GrDh9wFsPRVHrjGro6SD2eYRwazh7EYHexGetq2Ib0P/Uak1E4PfAGDnIV3VFvLiEa0FvMQKGMQAyw3EKBnELagN5jFurOJMTO8ywUyFGkBw/vMB11pR0NyNPq2DXTrgb0CqNQNc00cATpAbvihVo1zTQwFmdwLnERd/ADjunnAOSmmQaqZTtiXO+03LSrgRX4NxtYBSeQOGdXEBveLNcasRppchv4glih2ziAvXAmjPoFrMcG3C/XjsNtP5eXveD2w3ngG/ogkttAFOXgaRzc+snS0p/sg/WlpaXOOcNl7/H+iC81EJGaDVwvLWXZFNzDQzyH6+JauIwHiPppmK140vlntgAxZqEGHMScR9TCJpjBOIzvsP4C3eCMdwzmBGK/Qg2sKS1l2Q1ELXyE652qTQdi3VT49uQ3d+r2/Me6Qg0cKi1l2Vr8RNRlA356akx6q+6wQGzOGS/qKtSALw9DLBAvptHwdnLdSkzENBiXY79bFsrZjairUAPyQlqCkRgPbz3rWzAUDrgILxH7eD144Y7Bo3IteEdEchuIg7Sad0ya3AYq8//NBZX56w148cWG8y20KOmdM8xCXgYhngPxdGxFDsIxnSd6WqgWp2E39nV6Dor8OKmMD6jFSGfMmpmJ9GeWT0IfVI34hHScCagrc5E+cJr1FLNRKP2wDLvgi0YjdmIh+qIiWfYbBZl+g04mXm4AAAAASUVORK5CYII=" ),
        // Please specify the base64 content of a 80x80 pixels image
        ExportMetadata ( "BigImageBase64" , "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" ),
        ExportMetadata ( "BackgroundColor" , "Lavender" ),
        ExportMetadata ( "PrimaryFontColor" , "Black" ),
        ExportMetadata ( "SecondaryFontColor" , "Gray" )]
    public class CSVImporterPlugin : PluginBase
    {
        public override IXrmToolBoxPluginControl GetControl()
        {
            return new CSVImporterControl ( );
        }
    }
}