string[] input = {"hello", "world", "2", ":-)"};
string[] output = new string[] {};
int filterLength = 3;

input = askArray(input);
output = filterArray(input, filterLength);
printOutput(output);

string[] askArray (string[] arr) {
    Console.WriteLine("Write string or press Enter");
    string console = Console.ReadLine();
    string[] port = console.Split(",");
    string[] ret = new string[0];

    if (port.Length > 1) {
        Array.Resize(ref ret, port.Length);
        port.CopyTo(ret, 0);
    } else {
        Array.Resize(ref ret, arr.Length);
        arr.CopyTo(ret, 0);
    }


    return ret;
}

string[] filterArray(string[] inp, int len) {
    string[] ret = {};
    for (int i = 0; i < inp.Length; i++) {
        if (inp[i].Length <= len) {
            ret = ret.Append(inp[i]).ToArray();
        }
    }
    return ret;
}

void printOutput(string[] ret) {
    for (int i = 0; i < ret.Length; i++) {
        if (i < ret.Length - 1) {
            Console.Write("[{0}],", ret[i]);
        } else {
            Console.Write("[{0}]", ret[i]);
        }
    }
}