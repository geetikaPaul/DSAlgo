using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    public class Element
    {
        public int value { get; set; }
        public Element left { get; set; }
        public Element right { get; set; }
    }
    public class BST
    {       
        private Element root { get; set; }

        public BST()
        {
            root = null;
        }

        public void insert(int n)
        {
            this.root = insert(this.root, n);
        }
        private Element insert(Element element, int n)
        {
            if(element == null)
            {
                Element newElement = new Element() { value = n, left = null, right = null };
                return newElement;
            }

            else if(n< element.value)
            {
                element.left = insert(element.left, n);
            }

            else if (n > element.value)
            {
               element.right = insert(element.right, n);
            }

            return element;
        }

        public void inorderTraversal()
        {
            inorderTraversal(root);
        }
        private void inorderTraversal(Element element)
        {
            if (element != null)
            {
                inorderTraversal(element.left);
                Console.WriteLine(element.value);
                inorderTraversal(element.right);
            }
        }

        public Element Search(int n)
        {
            return Search(root, n);
        }
        private Element Search(Element element, int n)
        {
            if (element == null || element.value == n)
                return element;
            else if (n < element.value)
                return Search(element.left, n);
            else
                return Search(element.right, n);
        }

        public Element TreeMinimum()
        {
            return TreeMinimum(root);
        }

        private Element TreeMinimum(Element element)
        {
            if (element.left == null)
                return element;
            return TreeMinimum(element.left);
        }

        public Element TreeMaximum()
        {
            return TreeMaximum(root);
        }

        private Element TreeMaximum(Element element)
        {
            if (element.right == null)
                return element;
            //Console.Write(" " + element.value.ToString());
            return TreeMaximum(element.right);
        }

        public Element SuccessorFinder(int n)
        {
            Element successor = new Element();
            SuccessorFinder(root, ref successor, n);
            return successor;
        }
        private void SuccessorFinder(Element element, ref Element successor, int n)
        {
            if (element == null)
                return;
            if(element.value == n)
            {
                if(element.right!=null)                
                    successor = TreeMinimum(element.right);
            }

            else if(n < element.value)
            {
                successor = element;
                SuccessorFinder(element.left, ref successor, n); 
            }

            else
            {
                SuccessorFinder(element.right, ref successor, n);
            }
        }

        public Element PredecessorFinder(int n)
        {
            Element predecessor = new Element();
            PredecessorFinder(root, ref predecessor, n);
            return predecessor;
        }
        private void PredecessorFinder(Element element, ref Element predecessor, int n)
        {
            if (element == null)
                return;
            if (element.value == n)
            {
                if (element.left != null)
                    predecessor = TreeMaximum(element.left);
            }

            else if (n < element.value)
            {               
                PredecessorFinder(element.left, ref predecessor, n);
            }

            else
            {
                predecessor = element;
                PredecessorFinder(element.right, ref predecessor, n);
            }
        }

        public void Delete(int n)
        {
            this.root = Delete(root, n);
        }

        private Element Delete(Element element, int n)
        {
            if (element == null)
                return null;

            else if (n < element.value)
                element.left = Delete(element.left, n);

            else if (n > element.value)
                element.right = Delete(element.right, n);

            else
            {
                if (element.right == null && element.left == null)
                    element = null;

                else if (element.right == null)
                    element = element.left;

                else if (element.left == null)
                    element = element.right;

                else
                {                    
                    element.value = SuccessorFinder(element.value).value;
                    element.right = Delete(element.right, element.value);
                }
            }

            /*if(element!=null)
            Console.WriteLine("returning " + element.value.ToString());*/

            return element;
        }
    }
}
