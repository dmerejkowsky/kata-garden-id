def is_valid_id(value):
    if len(value) != 7:
        return False
    for character in value:
        if not character.isdigit():
            return False
    return True
