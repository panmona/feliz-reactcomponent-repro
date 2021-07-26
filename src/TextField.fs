namespace App

open Browser.Types

type Formatter = {
    format: string -> string
    unFormat: string -> string
}

type BrowserEventTarget = {
    value: string
}

type MinimalBrowserEvent = {
    target: BrowserEventTarget
}

type InnerInputProps = {
    inputRef: HTMLInputElement -> unit
    onAnimationStart: AnimationEvent -> unit
    onBlur: FocusEvent -> unit
    onFocus: FocusEvent -> unit
    id: string
    value: string
    onChange: MinimalBrowserEvent -> unit
    className: string
    disabled: bool
    formatter: Formatter
    inputmode: string
    placeholder: string
}