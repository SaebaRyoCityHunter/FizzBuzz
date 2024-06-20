﻿open System

[<EntryPoint>]
let main argv =
    [1..100] 
    |> Seq.map (fun x ->
        match x with
        | x when x%5=0 && x%3=0 -> "FizzBuzz"
        | x when x%3=0 -> "Fizz"
        | x when x%5=0 -> "Buzz"
        | x -> string x)
    |> Seq.iter (printfn "%s")
    0
