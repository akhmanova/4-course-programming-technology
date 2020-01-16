
open System 
[<EntryPoint>] 
let main argv =  
    // var 1
    // input: seq with numbers
    // output: cnt and sum of x < 0
    let mutable cnt_sum = 0
    let mutable cnt = 0
    let find_amount x = 
        if x < 0 then
            cnt_sum <- cnt_sum + x
            cnt <- cnt + 1

    let get_sum seqs = 
        Seq.iter find_amount seqs
    get_sum (seq [1; 2; 3; -1; -2])
    printfn "%A" (cnt)
    printfn "%A" (cnt_sum) 

    // var 9
    // input: seq with numbers
    // output: cnt of changed signs
    let mutable sign = 0
    let mutable cnt_s = 0
    let find_sign x = 
        if (x * sign) < 0 then
            cnt_s <- cnt_s + 1
        sign <- x

    let get_res seqs = 
        Seq.iter find_sign seqs
    get_res (seq [-1; 2; 3; -1; -2])
    printfn "%A" (cnt_s)
    
    // var 24 
    // input: dir and file_name
    // output: print file_name
    // let dir = System.Console.ReadLine();
    // let file_name = System.Console.ReadLine();

    // open System.IO

    // Directory.GetFiles(dir, file_name) 
    // |> Array.map Path.GetFileName 
    // |> Array.iter (printfn "%s")     


    Console.ReadKey() |> ignore 
    0

