const isValidId = (value) => {
  if (value.length != 7) {
    return false
  }

  for (const c of value) {
    if (c <= '0' || c >= '9') {
      return false
    }
  }

  return true
}

module.exports = isValidId
