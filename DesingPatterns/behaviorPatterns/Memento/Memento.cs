using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.behaviorPatterns.Memento
{
    public class Document  
    {
        private string content;

        public void SetContent(string content)
        {
            this.content = content;
        }

        public string GetContent()
        {
            return content;
        }

        public DocumentMemento SaveToMemento()
        {
            return new DocumentMemento(content);
        }

        public void RestoreFromMemento(DocumentMemento memento)
        {
            content = memento.GetContent();
        }
    }
    public class DocumentMemento
    {
        private readonly string content;

        public DocumentMemento(string content)
        {
            this.content = content;
        }

        public string GetContent()
        {
            return content;
        }
    }
    public class DocumentHistory
    {
        private Stack<DocumentMemento> history = new Stack<DocumentMemento>();

        public void Save(Document document)
        {
            history.Push(document.SaveToMemento());
        }

        public void Undo(Document document)
        {
            if (history.Count > 0)
            {
                document.RestoreFromMemento(history.Pop());
            }
        }
    }
}
