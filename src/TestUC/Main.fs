module TestUC

open Robkuz.Util.UnionCase

type Foo =
    | Bar
    | Baz

let (isBar, isBaz) = makeUnionCaseTest2<Foo>()