class DisposePatternImplementer : CloseableResource, IDisposable
    {
        private bool disposed = false;
      
       ~DisposePatternImplementer()
        {
           
            
            
            Dispose(false);
            
           
        }
        public void Dispose()
        {
             
            Dispose(true);
            GC.SuppressFinalize(this);
           
        }
        protected virtual void Dispose(bool disposing)
        {
             
            if (!disposed)
            {
                
              
                if (disposing)
                {
                    Console.WriteLine("Disposing by developer");
                   
                }
                
                else
                {
                   Console.WriteLine("Disposing by GC"); 
                }
                 Close(); 
            }
            
            disposed = true;
        }
       

       
    } 
