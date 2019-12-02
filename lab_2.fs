// var 9
// input: len of a list
// output: [0; 1; 0; ... ; 0; 1; 0] len from input
open System 
[<EntryPoint>] 
let main argv =  
    let gen n = 
        [  
        for i in 1 .. n do 
            if i % 2 = 0 then 
                yield 1 
            else 
                yield 0  
        ]
     
    printfn "%A" (gen 5) 
    Console.ReadKey() |> ignore 
    0
 
