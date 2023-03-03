package fr.arolla.garden;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertFalse;
import static org.junit.jupiter.api.Assertions.assertTrue;

public class GardenIdTest {
  @Test
  void accepts_valid_garden_id() {
    String validId = "1234567";
    var isValid = GardenId.check(validId);
    assertTrue(isValid);
  }

  @Test
  void rejects_too_big_id() {
    String tooBig = "123456789";
    var isValid = GardenId.check(tooBig);
    assertFalse(isValid);
  }

  @Test
  void rejects_too_small_id() {
    String tooSmall = "123";
    var isValid = GardenId.check(tooSmall);
    assertFalse(isValid);
  }

  @Test
  void rejects_id_containing_non_digits_characters() {
    String withInvalidCharacters = "123A456";
    var isValid = GardenId.check(withInvalidCharacters);
    assertFalse(isValid);
  }
}
