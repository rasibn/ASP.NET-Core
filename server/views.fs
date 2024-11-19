module server.views

open Giraffe.ViewEngine

type Message =
    { Text : string }
    

let layout (content: XmlNode list) =
    html [] [
        head [] [
            title []  [ encodedText "lingopher" ]
            link [ _rel  "stylesheet"
                   _type "text/css"
                   _href "/main.css" ]
        ]
        body [] content
    ]

let partial () =
    h1 [] [ encodedText "lingopher" ]

let index (model : Message) =
    [
        partial()
        p [] [ encodedText model.Text ]
    ] |> layout
