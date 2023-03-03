const isValidId = require('./index')
const test = require('tape')

test('accepts valid id', t => {
  const res = isValidId('1234567')
  t.ok(res)
  t.end()
})

test('rejects too big id', t => {
  const res = isValidId('1234567890')
  t.notOk(res)
  t.end()
})

test('rejects too small id', t => {
  const res = isValidId('12345')
  t.notOk(res)
  t.end()
})

test('rejects id containing non-digit characters', t => {
  const res = isValidId('1234A67')
  t.notOk(res)
  t.end()
})
