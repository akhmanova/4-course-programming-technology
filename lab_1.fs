open System 
[<EntryPoint>] 
let main argv =
    // var 1
    // input: three float digits
    // output: sum of cubed digits from input
    let sumOfCubed x y z = 
        x ** 3.0 + y ** 3.0 + z ** 3.0

    printfn "%A" (sumOfCubed 1.0 2.0 3.0)


    // var 9
    // input: integer number
    // output: factorial of the input
    let fact x = 
        let mutable res = 1
        let mutable n = x
        while n > 0 do
            res <- res * n
            n <- n - 1
        res
     
    printfn "%A" (fact 3) 


    // var 24
    // input: integer number
    // output: name of month from input
    let getMonth x = 
        match x with
        | 1 -> "January"
        | 2 -> "February"
        | 3 -> "March"
        | 4 -> "April"
        | 5 -> "May"
        | 6 -> "June"
        | 7 -> "July"
        | 8 -> "August"
        | 9 -> "September"
        | 10 -> "October"
        | 11 -> "November"
        | 12 -> "December"  
        | _ -> "Error"
    
    printfn "%A" (getMonth 12)
    Console.ReadKey() |> ignore 
    0 
