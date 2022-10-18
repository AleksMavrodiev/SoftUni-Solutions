let {assert} = require('chai');
let {lookupChar} = require("../charLookUp");

describe("testing type input for charLookUp", () => {
    it("should return undefined with invalid first parameter", () => {
        assert.equal(lookupChar([], 3), undefined);
    });

    it("should return undefined with decimal number", () => {
        assert.equal(lookupChar("Ivan", 0.99), undefined);
    })

    it("should return indefined with invalid second parameter", () => {
        assert.equal(lookupChar("Ivan", []), undefined);
    });

    it("should return `Incorrect index` with index < 0", () => {
        assert.equal(lookupChar("Ivan", -15), "Incorrect index");
    })

    it("should return `Incorrect index` with index >= length", () => {
        assert.equal(lookupChar("Ivan", 4), "Incorrect index");
    })

    it("should return proper char at index", () => {
        assert.equal(lookupChar("Ivan", 1), 'v');
    })
})