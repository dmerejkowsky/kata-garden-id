from garden import is_valid_id


def test_accepts_valid_id():
    assert is_valid_id("1234567")


def test_rejects_too_small_id():
    assert not is_valid_id("1234")


def test_rejects_too_big_id():
    assert not is_valid_id("1234567890")


def test_rejects_id_containing_non_digits_characters():
    assert not is_valid_id("123A567")
