using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Runtime.CompilerServices;

namespace CharacterGenerator.User
{
    internal class CharacterCache<T>
    {
        private Node<T> Head;
        private Node<T> Tail;
        private Dictionary<string, Node<T>> Hash = new Dictionary<string, Node<T>>();
        private Dictionary<Node<T>, string> ReverseHash = new Dictionary<Node<T>, string>();

        private int Capacity;
        public CharacterCache(int capacity)
        {
            Capacity = capacity;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            Node<T> node = Head;
            while( node != null)
            {
                stringBuilder.Append(node.Value.ToString());
                node = node.Next;
            }
            return stringBuilder.ToString();
        }

        public dynamic GetCharacterById(string id)
        {
            if (Hash.TryGetValue(id, out Node<T> characterNode))
            {
                if (!IsHead(characterNode))
                {
                    Node<T> prev = characterNode.Prev;
                    characterNode.Prev = null;
                    prev.Next = characterNode.Next;
                    UpdateHead(characterNode);
                }
                return characterNode.Value;
            }
            return null;
        }

        private void UpdateHead(Node<T> newHead)
        {
            Node<T> oldHead = Head;
            Head = newHead;
            if (oldHead == null)
            {
                Head.Next = Tail;
                Tail.Prev = Head;
                return;
            }
            Head.Next = oldHead;
            oldHead.Prev = Head;
        }

        private bool IsHead(Node<T> node)
        {
            return JsonSerializer.Serialize(node) == JsonSerializer.Serialize(Head);
            //return JsonConverter.Equals(node, Head);
        }

        public void AddNode(T nodeValue)
        {
            Node<T> node = new Node<T>(nodeValue);

            string nodeId = Guid.NewGuid().ToString();
            Hash.Add(nodeId, node);
            ReverseHash.Add(node, nodeId);

            if (Tail == null)
            {
                Tail = node;
                return;
            }
            if (!IsUnderCapacity())
            {
                RemoveTail();
            }
            UpdateHead(node);
        }
        private bool IsUnderCapacity()
        {
            return Hash.Count <= Capacity;
        }

        private T RemoveTail()
        {
            Node<T> oldTail = Tail;
            string olTailId = ReverseHash[Tail];

            Tail = oldTail.Prev;
            Tail.Next = null;

            Hash.Remove(olTailId);
            ReverseHash.Remove(oldTail);

            return Tail.Value;
        }
    }

    internal class Node<T>
    {
        public T Value;
        public Node<T> Next;
        public Node<T> Prev;
        public Node(T value) { Value = value; }
    }
}
