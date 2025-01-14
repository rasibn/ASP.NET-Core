﻿module server.handlers

open Giraffe
open server.views

let indexHandler (name : string) =
    let greetings = $"Hello {name}, from Giraffe!"
    let model     = { Text = greetings }
    let view      = index model
    htmlView view


