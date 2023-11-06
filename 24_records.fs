type TimeOfDay = { hours: int; minutes: int; f: string }

let time_compare = function
 | {hours = h; minutes = m; f = "PM"} -> {hours = h + 12; minutes = m; f = ""}
 | {hours = h; minutes = m; f = _} -> {hours = h; minutes = m; f = ""}

let (.>.) x y = time_compare(x) > time_compare(y)