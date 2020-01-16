
open System 
[<EntryPoint>] 
let main argv =  
    // var 1
    // input: seq with numbers
    // output: cnt and sum of x < 0
    type Tree = 
        | Tree of (string * Tree list)

    [<CompilationRepresentationAttribute(CompilationRepresentationFlags.ModuleSuffix)>]
    module Tree = 
        let find p tree = 
            let rec findInner t =
                match t with
                | Tree(n, _) when p(n) -> Some(t)
                | Tree(_, children) -> children |> Seq.choose (findInner) 
                                                |> Seq.tryFind (fun _ -> true)
                | Tree(_, []) -> None
            findInner tree
    let tree = Tree("A", 
                [Tree("B", 
                    [Tree("C",[]); 
                     Tree("D", 
                        [Tree("E",[])])
                    ]); 
                Tree("F",[])
                ])

    tree |> Tree.find (fun n -> n = "B") |> printfn "%A"
    tree |> Tree.find (fun n -> n = "D") |> printfn "%A"
    tree |> Tree.find (fun n -> n = "E") |> printfn "%A"
    tree |> Tree.find (fun n -> n = "TEST") |> printfn "%A"
    tree |> Tree.find (fun n -> n = "F") |> printfn "%A"


      


    Console.ReadKey() |> ignore 
    0

