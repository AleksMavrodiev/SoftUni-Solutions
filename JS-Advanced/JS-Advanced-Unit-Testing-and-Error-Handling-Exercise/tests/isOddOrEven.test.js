let {assert} = require("chai");
let {isOddOrEven} = require("../isOddOrEven");

describe("testing type input for isEvenOrOdd", () => {
    it("should return undefined with empty array data type", () => {
        assert.equal(isOddOrEven([]), undefined);
    });

    it("should return undefined with empty object", () => {
        assert.equal(isOddOrEven({}), undefined);  
    });

    it("should return odd with odd string", () => {
        assert.equal(isOddOrEven("Sasho"), "odd");
    });

    it("should return even with even string", () => {
        assert.equal(isOddOrEven("love"), "even");
    });


})

