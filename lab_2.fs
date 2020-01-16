// var 9
// input: len of a list
// output: [0; 1; 0; ... ; 0; 1; 0] len from input
open System 
[<EntryPoint>] 
let main argv =  
    let numbers n = 
    // var 1
    // input: number
    // output: list of digits from number
        [
        let mutable x = n  
        while x > 0 do 
            yield x % 10
            x <- x / 10 
        ]

    let rec reverse list =
        match list with
        |[] -> []
        |[x] -> [x]
        | head::tail -> reverse tail @ [head]

    printfn "%A" (reverse (numbers 12345)) 

    let gen n = 
        [  
        for i in 1 .. n do 
            if i % 2 = 0 then 
                yield 1 
            else 
                yield 0  
        ]
     
    printfn "%A" (gen 5) 
    
    // var 24
    // input: 
    // output:  ['a'; 'A'; 'b'; 'B'; 'c'; 'C'; 'd'; ..]
    let alpha = "abcdefghijklmnopqrstucwxyz"
    
    let get_alpha = 
        [
        for i in 0..25 do
            yield alpha.Chars(i)
            yield System.Char.ToUpper (alpha.Chars(i))
        ]
    printfn "%A" (get_alpha) 

    Console.ReadKey() |> ignore 
    0
 
