namespace App

open Feliz

type Components =
    [<ReactComponent>]
    static member HelloWorld() = Html.h1 "Hello World"
    
    [<ReactComponent>]
    static member App() =
        Html.div [
            prop.children [
                Components.HelloWorld ()
                Html.h2 "React.functionComponent"
                Html.div [
                    prop.children [
                        TextFieldFunctionComponent.TextField ()
                    ]
                ]
                Html.h2 "<ReactComponent>"
                Html.div [
                    prop.children [
                        TextFieldAnnotation.TextField ()
                    ]
                ]
            ]
        ]