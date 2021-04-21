export { }
declare global {
  interface Array<T> {
    where(property, value): T[];
  }
}

if (!Array.prototype.where) {
  Object.defineProperty(Array.prototype, 'where',  function where<T>(property, value): T[] {
      var ar:T[] = [];
      var obj:T;
      for (var i = 0; i < this.length; i++) {
        obj = this[i];
        if (obj.hasOwnProperty(value)) {
          if (obj[property] === value) ar.push(obj);
        }
      }
      return ar;
    
  });
}
