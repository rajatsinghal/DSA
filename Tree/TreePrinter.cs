using System;

namespace CSharp.Tree.TreePrinter {

    public enum NodePosition {
        left, right, center
    }

    public class PrintableNode {

        public virtual string getText() {
            return "";
        }
        public virtual PrintableNode getRight() {
            return null;
        }
        public virtual PrintableNode getLeft() {
            return null;
        }

        public void PrintPretty(string indent, NodePosition nodePosition, bool last, bool empty) {
            Console.Write(indent);
            if (last) {
                Console.Write("└─");
                indent += "  ";
            } else {
                Console.Write("├─");
                indent += "| ";
            }

            var stringValue = empty ? "-" : getText();
            switch (nodePosition) {
                case NodePosition.left:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("L:");
                    Console.ForegroundColor = (stringValue == "-") ? ConsoleColor.Red : ConsoleColor.Gray;
                    Console.WriteLine(stringValue);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case NodePosition.right:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("R:");
                    Console.ForegroundColor = (stringValue == "-") ? ConsoleColor.Red : ConsoleColor.Gray;
                    Console.WriteLine(stringValue);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case NodePosition.center:
                    Console.WriteLine(stringValue);
                    break;
                default:
                    throw new NotImplementedException();
            }

            if (!empty && (this.getLeft() != null || this.getRight() != null)) {
                if (this.getLeft() != null)
                    this.getLeft().PrintPretty(indent, NodePosition.left, false, false);
                else
                    PrintPretty(indent, NodePosition.left, false, true);

                if (this.getRight() != null)
                    this.getRight().PrintPretty(indent, NodePosition.right, true, false);
                else
                    PrintPretty(indent, NodePosition.right, true, true);
            }
        }
    }
}