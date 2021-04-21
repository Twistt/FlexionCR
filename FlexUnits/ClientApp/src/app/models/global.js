"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
if (!Array.prototype.where) {
    Object.defineProperty(Array.prototype, 'where', function where(property, value) {
        var ar = [];
        var obj;
        for (var i = 0; i < this.length; i++) {
            obj = this[i];
            if (obj.hasOwnProperty(value)) {
                if (obj[property] === value)
                    ar.push(obj);
            }
        }
        return ar;
    });
}
//# sourceMappingURL=global.js.map