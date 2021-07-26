module Main

open Feliz
open App
open Browser.Dom
open Fable.Core.JsInterop

importSideEffects "./styles/global.scss"

ReactDOM.render(
    Components.App(),
    document.getElementById "feliz-app"
)