namespace App

open Feliz
open Feliz.MaterialUI

module TextFieldAnnotation =
    /// This is used internally to render formatted input
    /// Implementation based on https://material-ui.com/components/text-fields/#integration-with-3rd-party-input-libraries
    /// Actual formatting logic was removed to make this repro a bit simpler
    [<ReactComponent>]
    let private FormattedInput (props: InnerInputProps) =
        let intState, setIntState = React.useState props.value
        let ref = React.useRef None

        // Updates the formatted internal state with the new value
        React.useEffect (fun () ->
            props.value
            |> setIntState
        , [| box props.value  |])

        // Injects the cleaned value into the change event
        let wrappedOnChange (value: string) =
            props.onChange {
                target = {
                    value = value
                }
            }

        Html.input [
            prop.id props.id
            prop.value intState
            prop.onChange wrappedOnChange
            prop.className props.className
            prop.ref ref
            prop.onAnimationStart props.onAnimationStart
            prop.onBlur props.onBlur
            prop.onFocus props.onFocus
            prop.placeholder props.placeholder
            prop.custom ("inputMode", props.inputmode)
        ]
    
    [<ReactComponent>]
    let TextField () =
        let value, setValue = React.useState ""
        let formatter = {
            format = id
            unFormat = id
        }
        
        Mui.textField [
            textField.label "My Label"
            textField.value value
            textField.onChange setValue
            textField.InputProps [
                prop.custom("inputComponent", FormattedInput)
                textField.inputProps [
                    prop.custom("formatter", formatter)
                ]
            ]
        ]
