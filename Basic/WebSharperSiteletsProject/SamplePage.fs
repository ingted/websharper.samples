//------------------------------------------------------------------------
// <generated>
//    This code was generated by WebSharper xhtml2fs version 2.1.0.
//
//    Changes to this file will be lost is the code is regenerated.
// </generated>
//------------------------------------------------------------------------
namespace Website.Templates.Templates

module SamplePage =
 open System.Web.UI
 open IntelliFactory.Html
 open IntelliFactory.WebSharper
 open IntelliFactory.WebSharper.Sitelets
 
 type SamplePageArgs<'Action> =
  {Content: Context<'Action> -> list<Element<Web.Control>>
   Caption: Context<'Action> -> list<Element<Web.Control>>
   Back: Context<'Action> -> list<Element<Web.Control>>}
 
 let SamplePageBody context (args: SamplePageArgs<'Action>) =
  [Div [
    Table [
     TR [
      TD [
       ] -< [ Text "
          " ] -< [
       ] -< args.Back context -< 
       [ Text "
        " ] -< [
      ]
     ]
     TR [
      TD [
       ] -< [ Text "" ] -< [
       ] -< args.Caption context -< 
       [ Text "" ] -< [
      ]
     ]
     TR [
      TD [
       ] -< [ Text "" ] -< [
       ] -< args.Content context -< 
       [ Text "" ] -< [
      ]
     ]
    ]
   ]]
 
 let SamplePage title (args: SamplePageArgs<'Action>) =
  PageContent <| fun context ->
   {Sitelets.Page.Default with
      Title = title
      Head =  []
      Body = SamplePageBody context args}
 