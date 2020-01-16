
open System 
[<EntryPoint>] 
let main argv =  
    // var 1
    // input: list with numbers
    // output:  sum of numbers
    let get_sum list = 
        List.sum list
    
    printfn "%A" (get_sum [1..10]) 

    // var 9
    // input: list with numbers
    // output: max element
    let mutable max_el = 0
    let max x =
        if max_el < x then
            max_el <- x
    
    let get_max list =
        List.iter max list
    
    get_max [1..10]
    printfn "%A" (max_el) 

    // var 24
    // input: list and number
    // how often number appears in list
    let x = System.Console.ReadLine();
    let num = x |> int
    let mutable amount = 0
    let plus y = 
        if y = num then
            amount <- amount + 1
    let get_amount list = 
        List.iter plus list

    get_amount [1..100]
    printfn "%A" (amount) 

    Console.ReadKey() |> ignore 
    0

