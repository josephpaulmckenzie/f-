let fizzBuzz x =
    match x with
    | _ when (x % 15) = 0 -> "Newfies"
    | _ when (x % 3) = 0 -> "Teecee"
    | _ when (x % 5) = 0 -> "Coder"
    | _ -> ""

let fizzBuzzTo max =
    [1..max] 
        |> List.iter (fun number -> printfn "%d %s" number (fizzBuzz number)) 
        |> ignore

fizzBuzzTo 100