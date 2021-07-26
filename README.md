# Feliz ReactComponent Reproduction

This app was created with [Feliz Template](https://zaid-ajaj.github.io/Feliz/#/Feliz/ProjectTemplate).

## Reproduction
1.
```bash
npm install
npm start
```

2. type into text field below `[<ReactComponent>]`

## Expected Result
The input field doesn't lose focus

## Actual Result
The input field loses focus

## Info
This didn't happen before when using React.functionComponent 
(See the difference between [TextFieldFunctionComponent](https://github.com/panmau/feliz-reactcomponent-repro/blob/main/src/TextFieldFunctionComponent.fs) and [TextFieldAnnotation](https://github.com/panmau/feliz-reactcomponent-repro/blob/main/src/TextFieldAnnotation.fs))