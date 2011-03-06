//------------------------------------------------------------------------
// <generated>
//    This code was generated by WebSharper xhtml2fs version 2.1.0.
//
//    Changes to this file will be lost is the code is regenerated.
// </generated>
//------------------------------------------------------------------------
namespace WebSharperProject.Templates

module MasterPage =
 open System.Web.UI
 open IntelliFactory.Html
 open IntelliFactory.WebSharper
 open IntelliFactory.WebSharper.Sitelets
 
 type MasterPageArgs<'Action> =
  {Excel: Context<'Action> -> list<Element<Web.Control>>}
 
 let MasterPageBody context (args: MasterPageArgs<'Action>) =
  [Div [
    Div [Class "header"]
    Div [Class "content"] -< [
     Div [Class "left"] -< [
      Div [Id "Title"] -< [
       ] -< [ Text
        "Welcome to WebExcel - a simple WebSharper spreadsheet application running entirely in your browser." ]
        -< [
      ]
      Div [
       ] -< [ Text "Notes:" ] -< [
      ]
      UL [
       LI [
        ] -< [ Text
         "
              Possible cell values are numbers and formulas
            " ]
         -< [
       ]
       LI [
        ] -< [ Text
         "
              Formulas start with '=' sign
            " ] -< [
       ]
       LI [
        ] -< [ Text
         "
              Cells are referenced by their names (composed from column and row), for instance A1, B2
            " ]
         -< [
       ]
       LI [
        ] -< [ Text
         "
              Formulas can contain basic arithmetic operations (+, -, *, /), logical operations (>, <, =, <>, >=, <=), and functions
            " ]
         -< [
       ]
       LI [
        ] -< [ Text "
              Predefined functions are: " ] -< [
        Span [Class "function-name"] -< [
         ] -< [ Text "AVERAGE" ] -< [
        ]
        ] -< [ Text " and " ] -< [
        Span [Class "function-name"] -< [
         ] -< [ Text "IF" ] -< [
        ]
        ] -< [ Text ". 
              " ] -< [
        Div [Class "code"] -< [
         ] -< [ Text "=AVERAGE(A1, B1, 10)" ] -< [
        ]
        Div [Class "code"] -< [
         ] -< [ Text "=IF(A1 > 5, 1, C2)" ] -< [
        ]
       ]
       LI [
        ] -< [ Text
         "
              You can add custom functions defined in JavaScript. Click on 'Add function' button, enter function name and definition and press 'OK'. Function definition is a JavaScript function that returns a numeric value.
              " ]
         -< [
        Pre [Class "code"] -< [
         ] -< [ Text
          "
function (a, b)
{
  return a + b;
}
              " ] -< [
        ]
       ]
      ]
     ]
     Div [Class "right"] -< [
      ] -< [ Text "
          " ] -< [
      ] -< args.Excel context -< 
      [ Text "
        " ] -< [
     ]
    ]
   ]]
 
 let MasterPage title (args: MasterPageArgs<'Action>) =
  PageContent <| fun context ->
   {Sitelets.Page.Default with
      Title = title
      Head =  [Link [Style "text/css"; Rel "stylesheet"; HRef "Main.css"]]
      Body = MasterPageBody context args}
 