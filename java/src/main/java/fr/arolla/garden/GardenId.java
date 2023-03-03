package fr.arolla.garden;

public class GardenId {
  public static boolean check(String value) {
    if (value.length() != 7) {
      return false;
    }

    for (var c : value.toCharArray()) {
      if (!Character.isDigit(c)) {
        return false;
      }
    }

    return true;
  }
}
